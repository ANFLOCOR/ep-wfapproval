' This class is "generated" and will be overwritten.
' Your customizations should be made in Vw_ANFLO_DW_CompanyGPSqlView.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="Vw_ANFLO_DW_CompanyGPSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Vw_ANFLO_DW_CompanyGPView"></see> class.
''' </remarks>
''' <seealso cref="Vw_ANFLO_DW_CompanyGPView"></seealso>
''' <seealso cref="Vw_ANFLO_DW_CompanyGPSqlView"></seealso>

Public Class BaseVw_ANFLO_DW_CompanyGPSqlView
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
