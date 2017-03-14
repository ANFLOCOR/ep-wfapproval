' This class is "generated" and will be overwritten.
' Your customizations should be made in All_SysUserInfo_viewSqlView.vb  

Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="All_SysUserInfo_viewSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="All_SysUserInfo_viewView"></see> class.
''' </remarks>
''' <seealso cref="All_SysUserInfo_viewView"></seealso>
''' <seealso cref="All_SysUserInfo_viewSqlView"></seealso>

Public Class BaseAll_SysUserInfo_viewSqlView
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
	End Sub
	
	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
