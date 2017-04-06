' This class is "generated" and will be overwritten.
' Your customizations should be made in WFinRepNGP_DocAttachSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="WFinRepNGP_DocAttachSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WFinRepNGP_DocAttachTable"></see> class.
''' </remarks>
''' <seealso cref="WFinRepNGP_DocAttachTable"></seealso>
''' <seealso cref="WFinRepNGP_DocAttachSqlTable"></seealso>

Public Class BaseWFinRepNGP_DocAttachSqlTable
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
