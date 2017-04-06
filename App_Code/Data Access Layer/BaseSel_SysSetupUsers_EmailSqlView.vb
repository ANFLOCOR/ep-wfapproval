' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_SysSetupUsers_EmailSqlView.vb  

Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="Sel_SysSetupUsers_EmailSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_SysSetupUsers_EmailView"></see> class.
''' </remarks>
''' <seealso cref="Sel_SysSetupUsers_EmailView"></seealso>
''' <seealso cref="Sel_SysSetupUsers_EmailSqlView"></seealso>

Public Class BaseSel_SysSetupUsers_EmailSqlView
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
	End Sub
	
	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
