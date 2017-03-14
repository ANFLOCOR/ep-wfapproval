' This class is "generated" and will be overwritten.
' Your customizations should be made in SysSetupUsersSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="SysSetupUsersSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="SysSetupUsersTable"></see> class.
''' </remarks>
''' <seealso cref="SysSetupUsersTable"></seealso>
''' <seealso cref="SysSetupUsersSqlTable"></seealso>

Public Class BaseSysSetupUsersSqlTable
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
