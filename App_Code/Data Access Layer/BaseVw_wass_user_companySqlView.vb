' This class is "generated" and will be overwritten.
' Your customizations should be made in Vw_wass_user_companySqlView.vb  

Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="Vw_wass_user_companySqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Vw_wass_user_companyView"></see> class.
''' </remarks>
''' <seealso cref="Vw_wass_user_companyView"></seealso>
''' <seealso cref="Vw_wass_user_companySqlView"></seealso>

Public Class BaseVw_wass_user_companySqlView
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
	End Sub
	
	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
