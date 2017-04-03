' This class is "generated" and will be overwritten.
' Your customizations should be made in Vw_Conso_BSCategoriesSqlView.vb  

Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="Vw_Conso_BSCategoriesSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Vw_Conso_BSCategoriesView"></see> class.
''' </remarks>
''' <seealso cref="Vw_Conso_BSCategoriesView"></seealso>
''' <seealso cref="Vw_Conso_BSCategoriesSqlView"></seealso>

Public Class BaseVw_Conso_BSCategoriesSqlView
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
	End Sub
	
	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
