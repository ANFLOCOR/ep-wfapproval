' This class is "generated" and will be overwritten.
' Your customizations should be made in WCAR_ActivitySqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="WCAR_ActivitySqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WCAR_ActivityTable"></see> class.
''' </remarks>
''' <seealso cref="WCAR_ActivityTable"></seealso>
''' <seealso cref="WCAR_ActivitySqlTable"></seealso>

Public Class BaseWCAR_ActivitySqlTable
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
