' This class is "generated" and will be overwritten.
' Your customizations should be made in View_FS_PackageForConsoSqlView.vb  

Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="View_FS_PackageForConsoSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="View_FS_PackageForConsoView"></see> class.
''' </remarks>
''' <seealso cref="View_FS_PackageForConsoView"></seealso>
''' <seealso cref="View_FS_PackageForConsoSqlView"></seealso>

Public Class BaseView_FS_PackageForConsoSqlView
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
	End Sub
	
	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
