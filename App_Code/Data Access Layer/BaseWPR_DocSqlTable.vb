' This class is "generated" and will be overwritten.
' Your customizations should be made in WPR_DocSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="WPR_DocSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WPR_DocTable"></see> class.
''' </remarks>
''' <seealso cref="WPR_DocTable"></seealso>
''' <seealso cref="WPR_DocSqlTable"></seealso>

Public Class BaseWPR_DocSqlTable
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
