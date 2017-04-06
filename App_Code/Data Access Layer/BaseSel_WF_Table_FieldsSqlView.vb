' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_WF_Table_FieldsSqlView.vb  

Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="Sel_WF_Table_FieldsSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_WF_Table_FieldsView"></see> class.
''' </remarks>
''' <seealso cref="Sel_WF_Table_FieldsView"></seealso>
''' <seealso cref="Sel_WF_Table_FieldsSqlView"></seealso>

Public Class BaseSel_WF_Table_FieldsSqlView
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
	End Sub
	
	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
