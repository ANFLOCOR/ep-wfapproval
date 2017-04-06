' This class is "generated" and will be overwritten.
' Your customizations should be made in WAttach_TypeSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="WAttach_TypeSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WAttach_TypeTable"></see> class.
''' </remarks>
''' <seealso cref="WAttach_TypeTable"></seealso>
''' <seealso cref="WAttach_TypeSqlTable"></seealso>

Public Class BaseWAttach_TypeSqlTable
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
