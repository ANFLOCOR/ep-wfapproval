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
''' Also provides access to the <see cref="WCAR_DocTable"></see> that each record is associated with.
''' </summary>
''' <remarks>
''' </remarks>
''' <seealso cref="WCAR_DocTable"></seealso>

<Serializable()> Public Class WCAR_DocRecord
	Inherits BaseWCAR_DocRecord

	' Constructors
	
	Public Sub New()
		MyBase.New()
	End Sub
	
	


        Public Shared Sub UpdateRecord(ByVal WCD_ID As String, ByVal WCD_Status As String)

            Dim ws As String = "WCD_ID = " & WCD_ID
            Dim rec As New WCAR_DocRecord
            rec = WCAR_DocTable.GetRecord(ws)

            If Not rec Is Nothing Then
                WCD_ID = rec.WCD_ID.ToString()
                Utils.DbUtils.StartTransaction()
                Try
                    rec = WCAR_DocTable.GetRecord(WCD_ID, True)
                    rec.WCD_Status = WCD_Status
                    rec.Save()
                    Utils.DbUtils.CommitTransaction()
                Catch ex As Exception
                    Utils.DbUtils.RollBackTransaction()
                End Try
            End If
        End Sub

        Public Shared Sub UpdateRecord_Status_Submit(ByVal WCD_ID As String, ByVal WCD_Status As String, _
        ByVal WCD_Submit As String, ByVal WCD_Remark As String)

            Dim ws As String = "WCD_ID = " & WCD_ID
            Dim rec As New WCAR_DocRecord
            rec = WCAR_DocTable.GetRecord(ws)

            If Not rec Is Nothing Then
                WCD_ID = rec.WCD_ID.ToString()
                Utils.DbUtils.StartTransaction()
                Try
                    rec = WCAR_DocTable.GetRecord(WCD_ID, True)
                    rec.WCD_Status = WCD_Status
                    rec.WCD_Submit = WCD_Submit
                    rec.WCD_Remark = rec.WCD_Remark & vbcrlf & WCD_Remark
                    rec.Save()
                    Utils.DbUtils.CommitTransaction()
                Catch ex As Exception
                    Utils.DbUtils.RollBackTransaction()
                End Try
            End If
        End Sub

	

End Class
End Namespace
