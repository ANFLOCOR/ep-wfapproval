' This class is "generated" and will be overwritten.
' Your customizations should be made in WFinRep_ActivitySqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="WFinRep_ActivitySqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WFinRep_ActivityTable"></see> class.
''' </remarks>
''' <seealso cref="WFinRep_ActivityTable"></seealso>
''' <seealso cref="WFinRep_ActivitySqlTable"></seealso>

Public Class BaseWFinRep_ActivitySqlTable
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
