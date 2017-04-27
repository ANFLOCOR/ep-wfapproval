' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_WAttach_Type_WCAR_Doc_AttachSqlView.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="Sel_WAttach_Type_WCAR_Doc_AttachSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_WAttach_Type_WCAR_Doc_AttachView"></see> class.
''' </remarks>
''' <seealso cref="Sel_WAttach_Type_WCAR_Doc_AttachView"></seealso>
''' <seealso cref="Sel_WAttach_Type_WCAR_Doc_AttachSqlView"></seealso>

Public Class BaseSel_WAttach_Type_WCAR_Doc_AttachSqlView
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
