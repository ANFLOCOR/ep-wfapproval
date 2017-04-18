' This class is "generated" and will be overwritten.
' Your customizations should be made in WFinRepCon_ActivitySqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="WFinRepCon_ActivitySqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WFinRepCon_ActivityTable"></see> class.
''' </remarks>
''' <seealso cref="WFinRepCon_ActivityTable"></seealso>
''' <seealso cref="WFinRepCon_ActivitySqlTable"></seealso>

Public Class BaseWFinRepCon_ActivitySqlTable
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
