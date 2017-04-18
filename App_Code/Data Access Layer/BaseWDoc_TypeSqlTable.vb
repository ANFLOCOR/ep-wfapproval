' This class is "generated" and will be overwritten.
' Your customizations should be made in WDoc_TypeSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="WDoc_TypeSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WDoc_TypeTable"></see> class.
''' </remarks>
''' <seealso cref="WDoc_TypeTable"></seealso>
''' <seealso cref="WDoc_TypeSqlTable"></seealso>

Public Class BaseWDoc_TypeSqlTable
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
