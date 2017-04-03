' This class is "generated" and will be overwritten.
' Your customizations should be made in Vw_Conso_CFCategoriesSqlView.vb  

Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="Vw_Conso_CFCategoriesSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Vw_Conso_CFCategoriesView"></see> class.
''' </remarks>
''' <seealso cref="Vw_Conso_CFCategoriesView"></seealso>
''' <seealso cref="Vw_Conso_CFCategoriesSqlView"></seealso>

Public Class BaseVw_Conso_CFCategoriesSqlView
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
	End Sub
	
	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
