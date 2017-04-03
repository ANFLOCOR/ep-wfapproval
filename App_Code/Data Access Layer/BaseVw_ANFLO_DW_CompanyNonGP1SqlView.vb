' This class is "generated" and will be overwritten.
' Your customizations should be made in Vw_ANFLO_DW_CompanyNonGP1SqlView.vb  

Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="Vw_ANFLO_DW_CompanyNonGP1SqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Vw_ANFLO_DW_CompanyNonGP1View"></see> class.
''' </remarks>
''' <seealso cref="Vw_ANFLO_DW_CompanyNonGP1View"></seealso>
''' <seealso cref="Vw_ANFLO_DW_CompanyNonGP1SqlView"></seealso>

Public Class BaseVw_ANFLO_DW_CompanyNonGP1SqlView
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
	End Sub
	
	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
