' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_WASP_WF_ApproverSqlView.vb  

Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="Sel_WASP_WF_ApproverSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_WASP_WF_ApproverView"></see> class.
''' </remarks>
''' <seealso cref="Sel_WASP_WF_ApproverView"></seealso>
''' <seealso cref="Sel_WASP_WF_ApproverSqlView"></seealso>

Public Class BaseSel_WASP_WF_ApproverSqlView
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
	End Sub
	
	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
