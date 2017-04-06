' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_Approver_Pending_TasksSqlView.vb  

Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="Sel_Approver_Pending_TasksSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_Approver_Pending_TasksView"></see> class.
''' </remarks>
''' <seealso cref="Sel_Approver_Pending_TasksView"></seealso>
''' <seealso cref="Sel_Approver_Pending_TasksSqlView"></seealso>

Public Class BaseSel_Approver_Pending_TasksSqlView
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
	End Sub
	
	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
