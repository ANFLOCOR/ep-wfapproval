' This class is "generated" and will be overwritten.
' Your customizations should be made in View_FS_StatusAllCompanySqlView.vb  

Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="View_FS_StatusAllCompanySqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="View_FS_StatusAllCompanyView"></see> class.
''' </remarks>
''' <seealso cref="View_FS_StatusAllCompanyView"></seealso>
''' <seealso cref="View_FS_StatusAllCompanySqlView"></seealso>

Public Class BaseView_FS_StatusAllCompanySqlView
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
	End Sub
	
	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
