' This is a "safe" class, meaning that it is created once 
' and never overwritten. Any custom code you add to this class 
' will be preserved when you regenerate your application.
'
' Typical customizations that may be done in this class include
'  - adding custom event handlers
'  - overriding base class methods

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' Provides access to the data in a database record.
''' Also provides access to the <see cref="WFinRep_DocAttach1Table"></see> that each record is associated with.
''' </summary>
''' <remarks>
''' </remarks>
''' <seealso cref="WFinRep_DocAttach1Table"></seealso>

<Serializable()> Public Class WFinRep_DocAttach1Record
	Inherits BaseWFinRep_DocAttach1Record

	' Constructors
	
	Public Sub New()
		MyBase.New()
	End Sub
	


        Public Shared Sub AddRecord(ByVal FIN_Year As Integer, ByVal FIN_Month As Integer, ByVal FIN_Type As String, _
                    ByVal FIN_Description As String, ByVal FIN_Company As Integer, _
                    ByVal FIN_File1 As String, ByVal FIN_RptID As Integer)


            Dim rec As New WFinRep_DocAttachRecord

            Try
                Utils.DbUtils.StartTransaction()
                rec.FIN_Year = FIN_Year
                rec.FIN_Month = FIN_Month
                rec.FIN_Type = FIN_Type
                rec.FIN_Description = FIN_Description
                rec.FIN_Company = FIN_Company
                rec.FIN_Status = 4
                rec.FIN_File1 = FIN_File1
                rec.FIN_RptID = FIN_RptID
                rec.Save()
                Utils.DbUtils.CommitTransaction()
            Catch ex As Exception
                Utils.DbUtils.RollBackTransaction()
            End Try
        End Sub


        Public Shared Sub UpdateStatus(ByVal xFIN_ID As String, ByVal xFIN_Status As Integer)

            Dim ws As String = "FIN_ID = " & xFIN_ID
            Dim rec As New WFinRep_DocAttachRecord
            rec = WFinRep_DocAttachTable.GetRecord(ws)


            If Not rec Is Nothing Then
                xFIN_ID = rec.FIN_ID.ToString()
                Utils.DbUtils.StartTransaction()
                Try
                    rec = WFinRep_DocAttachTable.GetRecord(xFIN_ID, True)
                    rec.FIN_Status = xFIN_Status
                    rec.Save()
                    Utils.DbUtils.CommitTransaction()
                Catch ex As Exception
                    Utils.DbUtils.RollBackTransaction()
                End Try
            End If


        End Sub

        Public Shared Sub UpdateFinPost(ByVal xFIN_ID As String, ByVal xFIN_Post As Integer)

            Dim ws As String = "FIN_ID = " & xFIN_ID
            Dim rec As New WFinRep_DocAttachRecord
            rec = WFinRep_DocAttachTable.GetRecord(ws)

            Dim postflag As Boolean = Nothing

            If xFIN_Post = 0 Then
                postflag = False

            Else
                postflag = True
            End If

            If Not rec Is Nothing Then
                xFIN_ID = rec.FIN_ID.ToString()
                Utils.DbUtils.StartTransaction()
                Try
                    rec = WFinRep_DocAttachTable.GetRecord(xFIN_ID, True)
                    rec.FIN_Post = xFIN_Post
                    rec.Save()
                    Utils.DbUtils.CommitTransaction()
                Catch ex As Exception
                    Utils.DbUtils.RollBackTransaction()
                End Try
            End If


        End Sub



	

End Class
End Namespace
