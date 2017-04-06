' This class is "generated" and will be overwritten.
' Your customizations should be made in W_Module_SourceSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="W_Module_SourceSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="W_Module_SourceTable"></see> class.
''' </remarks>
''' <seealso cref="W_Module_SourceTable"></seealso>
''' <seealso cref="W_Module_SourceSqlTable"></seealso>

Public Class BaseW_Module_SourceSqlTable
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
