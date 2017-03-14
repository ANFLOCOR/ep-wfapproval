' This class is "generated" and will be overwritten.
' Your customizations should be made in SysSetupUserCompany_viewSqlView.vb  

Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="SysSetupUserCompany_viewSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="SysSetupUserCompany_viewView"></see> class.
''' </remarks>
''' <seealso cref="SysSetupUserCompany_viewView"></seealso>
''' <seealso cref="SysSetupUserCompany_viewSqlView"></seealso>

Public Class BaseSysSetupUserCompany_viewSqlView
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
	End Sub
	
	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
