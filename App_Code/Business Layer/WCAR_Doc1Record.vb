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
''' Also provides access to the <see cref="WCAR_Doc1Table"></see> that each record is associated with.
''' </summary>
''' <remarks>
''' </remarks>
''' <seealso cref="WCAR_Doc1Table"></seealso>

<Serializable()> Public Class WCAR_Doc1Record
	Inherits BaseWCAR_Doc1Record

	' Constructors
	
	Public Sub New()
		MyBase.New()
	End Sub
	
        Public Shared Sub AddRecord(ByVal WS_ID As String, ByVal WSD_ID As String, ByVal WDT_ID As String, _
           ByVal U_ID As String, ByVal U_ID_Delegate As String, ByVal WCD_ID As String, Optional ByVal WCA_Remark As String = "")

            Dim rec As New WCAR_Activity1Record

            Try
                Utils.DbUtils.StartTransaction()
                rec.WCA_WS_ID = WS_ID
                rec.WCA_WSD_ID = WSD_ID
                rec.WCA_WDT_ID = WDT_ID
                rec.WCA_W_U_ID = U_ID
                rec.WCA_W_U_ID_Delegate = U_ID_Delegate
                rec.WCA_WCD_ID = WCD_ID
                rec.WCA_Status = "Pending"
                rec.WCA_Date_Assign = Now.ToShortDateString()

                rec.WCA_Remark = WCA_Remark
                rec.WCA_Is_Done = 0

                rec.Save()
                Utils.DbUtils.CommitTransaction()
            Catch ex As Exception
                Utils.DbUtils.RollBackTransaction()
            End Try
        End Sub

        Public Shared Sub UpdateRecord(ByVal WCA_ID As String, ByVal WCA_Status As String)

            Dim ws As String = "WCA_ID = " & WCA_ID
            Dim rec As New WCAR_Activity1Record
            rec = WCAR_Activity1Table.GetRecord(ws)

            If Not rec Is Nothing Then
                WCA_ID = rec.WCA_ID.ToString()
                Utils.DbUtils.StartTransaction()
                Try
                    rec = WCAR_Activity1Table.GetRecord(WCA_ID, True)
                    rec.WCA_Status = WCA_Status
                    rec.WCA_Date_Action = Now.ToShortDateString()
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

        Public Shared Sub UpdateRecord_Prev_Rej_Invisible(ByVal WCA_ID As String)

            Dim ws As String = "WCA_ID = " & WCA_ID
            Dim rec As New WCAR_Activity1Record
            rec = WCAR_Activity1Table.GetRecord(ws)

            If Not rec Is Nothing Then
                WCA_ID = rec.WCA_ID.ToString()
                Utils.DbUtils.StartTransaction()
                Try
                    rec = WCAR_Activity1Table.GetRecord(WCA_ID, True)
                    'rec.WCA_Status = WCA_Status
                    'rec.WCA_Date_Action = Now.ToShortDateString()
                    rec.WCA_Is_Done = "1"
                    rec.Save()
                    Utils.DbUtils.CommitTransaction()
                Catch ex As Exception
                    Utils.DbUtils.RollBackTransaction()
                End Try
            End If
        End Sub

        'Public Shared Sub AssignTo(WCA_W_U_ID_Current As String, WCA_W_U_ID_Assign As String)

        '	Dim ws As String = "WCA_W_U_ID = " & WCA_W_U_ID_Current
        '	Dim rec As New WCAR_ActivityRecord
        '	rec = WCAR_ActivityTable.GetRecord(ws)	

        '	If Not rec Is Nothing Then
        '        WCA_W_U_ID_Current = rec.WCA_ID.ToString()
        '        Utils.DbUtils.StartTransaction()
        '        Try
        '            rec = WCAR_ActivityTable.GetRecord(WCA_W_U_ID_Current, True)

        '			rec.WCA_W_U_ID = WCA_W_U_ID_Assign
        '            rec.Save()
        '            Utils.DbUtils.CommitTransaction()
        '        Catch ex As Exception
        '            Utils.DbUtils.RollBackTransaction()
        '        End Try
        '	End If      				
        'End Sub

        Public Shared Sub AssignTo(ByVal WCA_ID As String, ByVal WCA_W_U_ID_Assign As String)

            Dim ws As String = "WCA_ID = " & WCA_ID
            Dim rec As New WCAR_Activity1Record
            rec = WCAR_Activity1Table.GetRecord(ws)

            If Not rec Is Nothing Then
                WCA_ID = rec.WCA_ID.ToString()
                Utils.DbUtils.StartTransaction()
                Try
                    rec = WCAR_Activity1Table.GetRecord(WCA_ID, True)

                    rec.WCA_W_U_ID = WCA_W_U_ID_Assign
                    rec.Save()
                    Utils.DbUtils.CommitTransaction()
                Catch ex As Exception
                    Utils.DbUtils.RollBackTransaction()
                End Try
            End If
        End Sub

	

End Class
End Namespace
