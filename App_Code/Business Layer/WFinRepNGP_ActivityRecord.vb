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
''' Also provides access to the <see cref="WFinRepNGP_ActivityTable"></see> that each record is associated with.
''' </summary>
''' <remarks>
''' </remarks>
''' <seealso cref="WFinRepNGP_ActivityTable"></seealso>

<Serializable()> Public Class WFinRepNGP_ActivityRecord
	Inherits BaseWFinRepNGP_ActivityRecord

	' Constructors
	
	Public Sub New()
		MyBase.New()
	End Sub
	
	
        Public Shared Sub AddRecord(ByVal WFRNGPA_WS_ID As Integer, ByVal WFRNGPA_WSD_ID As Integer, ByVal WFRNGPA_WDT_ID As Integer, _
                   ByVal WFRNGPA_W_U_ID As Integer, ByVal WFRNGPA_W_U_ID_Delegate As Integer, ByVal WFRNGPA_WFRCHNGP_ID As Integer, Optional ByVal WFRNGPA_Remark As String = "")

            Dim rec As New WFinRepNGP_ActivityRecord

            Try
                Utils.DbUtils.StartTransaction()
                rec.WFRNGPA_WS_ID = WFRNGPA_WS_ID
                rec.WFRNGPA_WSD_ID = WFRNGPA_WSD_ID
                rec.WFRNGPA_WDT_ID = WFRNGPA_WDT_ID
                rec.WFRNGPA_W_U_ID = WFRNGPA_W_U_ID
                rec.WFRNGPA_W_U_ID_Delegate = WFRNGPA_W_U_ID_Delegate
                rec.WFRNGPA_WFRCHNGP_ID = WFRNGPA_WFRCHNGP_ID
                rec.WFRNGPA_Status = 4 'NOTE: Change ApprovalStatus from 4 to 9
                rec.WFRNGPA_Date_Assign = Now()  '.ToShortDateString() '.ToString()

                rec.WFRNGPA_Remark = WFRNGPA_Remark
                rec.WFRNGPA_Is_Done = False ' 0

                rec.Save()
                Utils.DbUtils.CommitTransaction()
            Catch ex As Exception
                Utils.DbUtils.RollBackTransaction()
            End Try
        End Sub

        Public Shared Sub UpdateRecord(ByVal WFRNGPA_ID As String, ByVal WFRNGPA_Status As String)

            Dim ws As String = "WFRNGPA_ID = " & WFRNGPA_ID
            Dim rec As New WFinRepNGP_ActivityRecord
            rec = WFinRepNGP_ActivityTable.GetRecord(ws)

            If Not rec Is Nothing Then
                WFRNGPA_ID = rec.WFRNGPA_ID.ToString()
                Utils.DbUtils.StartTransaction()
                Try
                    rec = WFinRepNGP_ActivityTable.GetRecord(WFRNGPA_ID, True)
                    rec.WFRNGPA_Status = CInt(WFRNGPA_Status)
                    rec.WFRNGPA_Date_Action = Now()       '.ToString() 'ToShortDateString()
                    rec.Save()
                    Utils.DbUtils.CommitTransaction()
                Catch ex As Exception
                    Utils.DbUtils.RollBackTransaction()
                End Try
            End If

        End Sub

        Public Shared Sub UpdateRecord_Final_Approved(ByVal WFRNGPA_ID As String)

            Dim ws As String = "WFRNGPA_ID = " & WFRNGPA_ID
            Dim rec As New WFinRepNGP_ActivityRecord
            rec = WFinRepNGP_ActivityTable.GetRecord(ws)

            If Not rec Is Nothing Then
                WFRNGPA_ID = rec.WFRNGPA_ID.ToString()
                Utils.DbUtils.StartTransaction()
                Try
                    rec = WFinRepNGP_ActivityTable.GetRecord(WFRNGPA_ID, True)
                    rec.WFRNGPA_Is_Done = True '  "1"
                    rec.Save()
                    Utils.DbUtils.CommitTransaction()
                Catch ex As Exception
                    Utils.DbUtils.RollBackTransaction()
                End Try
            End If
        End Sub

	

End Class
End Namespace
