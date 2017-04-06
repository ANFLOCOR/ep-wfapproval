' This class is "generated" and will be overwritten.
' Your customizations should be made in WASS_Email_DefaultSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="WASS_Email_DefaultSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WASS_Email_DefaultTable"></see> class.
''' </remarks>
''' <seealso cref="WASS_Email_DefaultTable"></seealso>
''' <seealso cref="WASS_Email_DefaultSqlTable"></seealso>

Public Class BaseWASS_Email_DefaultSqlTable
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
