' This class is "generated" and will be overwritten.
' Your customizations should be made in SysSetupWASSEmailSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="SysSetupWASSEmailSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="SysSetupWASSEmailTable"></see> class.
''' </remarks>
''' <seealso cref="SysSetupWASSEmailTable"></seealso>
''' <seealso cref="SysSetupWASSEmailSqlTable"></seealso>

Public Class BaseSysSetupWASSEmailSqlTable
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
