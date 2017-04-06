' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_WASP_UserSqlView.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="Sel_WASP_UserSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_WASP_UserView"></see> class.
''' </remarks>
''' <seealso cref="Sel_WASP_UserView"></seealso>
''' <seealso cref="Sel_WASP_UserSqlView"></seealso>

Public Class BaseSel_WASP_UserSqlView
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
