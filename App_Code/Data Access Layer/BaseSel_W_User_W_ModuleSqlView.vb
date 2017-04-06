' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_W_User_W_ModuleSqlView.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="Sel_W_User_W_ModuleSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_W_User_W_ModuleView"></see> class.
''' </remarks>
''' <seealso cref="Sel_W_User_W_ModuleView"></seealso>
''' <seealso cref="Sel_W_User_W_ModuleSqlView"></seealso>

Public Class BaseSel_W_User_W_ModuleSqlView
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
