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
''' Also provides access to the <see cref="WFinRep_ActivityTable"></see> that each record is associated with.
''' </summary>
''' <remarks>
''' </remarks>
''' <seealso cref="WFinRep_ActivityTable"></seealso>

<Serializable()> Public Class WFinRep_ActivityRecord
	Inherits BaseWFinRep_ActivityRecord

	' Constructors
	
	Public Sub New()
		MyBase.New()
	End Sub
	

        Public Shared Sub AddRecord(ByVal AFIN_WS_ID As Integer, ByVal AFIN_WSD_ID As Integer, ByVal AFIN_WDT_ID As Integer, _
                ByVal AFIN_W_U_ID As Integer, ByVal AFIN_W_U_ID_Delegate As Integer, ByVal AFIN_FinID As Integer, Optional ByVal AFIN_Remark As String = "")

            Dim rec As New WFinRep_ActivityRecord

            Try
                Utils.DbUtils.StartTransaction()
                rec.AFIN_WS_ID = AFIN_WS_ID
                rec.AFIN_WSD_ID = AFIN_WSD_ID
                rec.AFIN_WDT_ID = AFIN_WDT_ID
                rec.AFIN_W_U_ID = AFIN_W_U_ID
                rec.AFIN_W_U_ID_Delegate = AFIN_W_U_ID_Delegate
                rec.AFIN_HFIN_ID = AFIN_FinID 'Changed to AFIN_HFIN_ID - change of reference for FS PACKAGE
                rec.AFIN_Status = 4 'NOTE: Change ApprovalStatus from 4 to 9
                rec.AFIN_Date_Assign = Now() '.ToShortDateString() '.ToString()

                rec.AFIN_Remark = AFIN_Remark
                rec.AFIN_Is_Done = False

                rec.Save()
                Utils.DbUtils.CommitTransaction()
            Catch ex As Exception
                Utils.DbUtils.RollBackTransaction()
            End Try
        End Sub



        Public Shared Sub UpdateRecord(ByVal AFIN_ID As String, ByVal AFIN_Status As Integer)

            Dim ws As String = "AFIN_ID = " & AFIN_ID
            Dim rec As New WFinRep_ActivityRecord
            rec = WFinRep_ActivityTable.GetRecord(ws)

            If Not rec Is Nothing Then
                AFIN_ID = rec.AFIN_ID.ToString()
                Utils.DbUtils.StartTransaction()
                Try
                    rec = WFinRep_ActivityTable.GetRecord(AFIN_ID, True)
                    rec.AFIN_Status = AFIN_Status
                    rec.AFIN_Date_Action = Now()       '.ToString() 'ToShortDateString()
                    rec.Save()
                    Utils.DbUtils.CommitTransaction()
                Catch ex As Exception
                    Utils.DbUtils.RollBackTransaction()
                End Try
            End If

        End Sub

        Public Shared Sub UpdateRecord_Final_Approved(ByVal AFIN_ID As String)

            Dim ws As String = "AFIN_ID = " & AFIN_ID
            Dim rec As New WFinRep_ActivityRecord
            rec = WFinRep_ActivityTable.GetRecord(ws)

            If Not rec Is Nothing Then
                AFIN_ID = rec.AFIN_ID.ToString()
                Utils.DbUtils.StartTransaction()
                Try
                    rec = WFinRep_ActivityTable.GetRecord(AFIN_ID, True)
                    rec.AFIN_Is_Done = True '"1"
                    rec.Save()
                    Utils.DbUtils.CommitTransaction()
                Catch ex As Exception
                    Utils.DbUtils.RollBackTransaction()
                End Try
            End If
        End Sub

        Public Shared Sub AssignTo(ByVal AFIN_ID As String, ByVal AFIN_W_U_ID As Integer)

            Dim ws As String = "AFIN_ID = " & AFIN_ID
            Dim rec As New WFinRep_ActivityRecord
            rec = WFinRep_ActivityTable.GetRecord(ws)

            If Not rec Is Nothing Then
                AFIN_ID = rec.AFIN_ID.ToString()
                Utils.DbUtils.StartTransaction()
                Try
                    rec = WFinRep_ActivityTable.GetRecord(AFIN_ID, True)

                    rec.AFIN_W_U_ID = AFIN_W_U_ID
                    rec.Save()
                    Utils.DbUtils.CommitTransaction()
                Catch ex As Exception
                    Utils.DbUtils.RollBackTransaction()
                End Try
            End If
        End Sub


	

End Class
End Namespace
