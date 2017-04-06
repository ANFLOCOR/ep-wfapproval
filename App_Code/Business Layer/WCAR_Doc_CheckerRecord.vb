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
''' Also provides access to the <see cref="WCAR_Doc_CheckerTable"></see> that each record is associated with.
''' </summary>
''' <remarks>
''' </remarks>
''' <seealso cref="WCAR_Doc_CheckerTable"></seealso>

<Serializable()> Public Class WCAR_Doc_CheckerRecord
	Inherits BaseWCAR_Doc_CheckerRecord

	' Constructors
	
	Public Sub New()
		MyBase.New()
	End Sub
	


        Public Shared Sub AddRecord(ByVal WCD_ID As String, ByVal U_ID As String)

            Dim rec As New WCAR_Doc_CheckerRecord

            Try
                Utils.DbUtils.StartTransaction()

                rec.WCDC_WCD_ID = WCD_ID
                rec.WCDC_U_ID = U_ID
                rec.Save()

                Utils.DbUtils.CommitTransaction()
            Catch ex As Exception
                Utils.DbUtils.RollBackTransaction()
            End Try
        End Sub

        Public Shared Sub UpdateRecord(ByVal WCD_ID As String, ByVal U_ID As String, ByVal Status As String, Optional ByVal Remark As String = "")

            Dim ws As String = "WCDC_WCD_ID = " & WCD_ID & " And WCDC_U_ID = " & U_ID
            Dim rec As New WCAR_Doc_CheckerRecord
            rec = WCAR_Doc_CheckerTable.GetRecord(ws)

            If Not rec Is Nothing Then
                Dim WCDC_ID As String = rec.WCDC_ID.ToString()
                Utils.DbUtils.StartTransaction()
                Try
                    rec = WCAR_Doc_CheckerTable.GetRecord(WCDC_ID, True)
                    rec.WCDC_Status = Status
                    rec.WCDC_Rem = rec.WCDC_Rem & vbcrlf & Status & ": " & Remark

                    rec.Save()
                    Utils.DbUtils.CommitTransaction()
                Catch ex As Exception
                    Utils.DbUtils.RollBackTransaction()
                End Try
            End If

            'rec = WCAR_ActivityTable.GetRecord(WCA_ID, True)

            'rec.WCA_Status = WCA_Status
            'rec.Save()         				
        End Sub


	

End Class
End Namespace
