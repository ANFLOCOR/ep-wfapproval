' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_WCAR_Doc_Creator_ApproverSqlView.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="Sel_WCAR_Doc_Creator_ApproverSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_WCAR_Doc_Creator_ApproverView"></see> class.
''' </remarks>
''' <seealso cref="Sel_WCAR_Doc_Creator_ApproverView"></seealso>
''' <seealso cref="Sel_WCAR_Doc_Creator_ApproverSqlView"></seealso>

Public Class BaseSel_WCAR_Doc_Creator_ApproverSqlView
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
