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
''' Also provides access to the <see cref="WFinRepNGP_DocAttach1Table"></see> that each record is associated with.
''' </summary>
''' <remarks>
''' </remarks>
''' <seealso cref="WFinRepNGP_DocAttach1Table"></seealso>

<Serializable()> Public Class WFinRepNGP_DocAttach1Record
	Inherits BaseWFinRepNGP_DocAttach1Record

	' Constructors
	
	Public Sub New()
		MyBase.New()
	End Sub
	
        Public Shared Sub UpdateStatus(ByVal xFIN_ID As String, ByVal xFIN_Status As Integer)

            Dim ws As String = "WFRCDNGP_ID = " & xFIN_ID
            Dim rec As New WFinRepNGP_DocAttach1Record
            rec = WFinRepNGP_DocAttach1Table.GetRecord(ws)


            If Not rec Is Nothing Then
                xFIN_ID = rec.WFRCDNGP_ID.ToString()
                Utils.DbUtils.StartTransaction()
                Try
                    rec = WFinRepNGP_DocAttach1Table.GetRecord(xFIN_ID, True)
                    rec.WFRCDNGP_Status = xFIN_Status
                    rec.Save()
                    Utils.DbUtils.CommitTransaction()
                Catch ex As Exception
                    Utils.DbUtils.RollBackTransaction()
                End Try
            End If


        End Sub

        Public Shared Sub UpdateFinPost(ByVal xFIN_ID As String, ByVal xFIN_Post As Integer)

            Dim ws As String = "WFRCDNGP_ID = " & xFIN_ID
            Dim rec As New WFinRepNGP_DocAttach1Record
            rec = WFinRepNGP_DocAttach1Table.GetRecord(ws)

            Dim postflag As Boolean = Nothing

            If xFIN_Post = 0 Then
                postflag = False

            Else
                postflag = True
            End If

            If Not rec Is Nothing Then
                xFIN_ID = rec.WFRCDNGP_ID.ToString()
                Utils.DbUtils.StartTransaction()
                Try
                    rec = WFinRepNGP_DocAttach1Table.GetRecord(xFIN_ID, True)
                    rec.WFRCDNGP_Post = postflag
                    rec.Save()
                    Utils.DbUtils.CommitTransaction()
                Catch ex As Exception
                    Utils.DbUtils.RollBackTransaction()
                End Try
            End If


        End Sub

	

End Class
End Namespace
