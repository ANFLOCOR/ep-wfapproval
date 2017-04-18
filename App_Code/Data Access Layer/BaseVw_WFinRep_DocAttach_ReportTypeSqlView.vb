' This class is "generated" and will be overwritten.
' Your customizations should be made in Vw_WFinRep_DocAttach_ReportTypeSqlView.vb  

Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="Vw_WFinRep_DocAttach_ReportTypeSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Vw_WFinRep_DocAttach_ReportTypeView"></see> class.
''' </remarks>
''' <seealso cref="Vw_WFinRep_DocAttach_ReportTypeView"></seealso>
''' <seealso cref="Vw_WFinRep_DocAttach_ReportTypeSqlView"></seealso>

Public Class BaseVw_WFinRep_DocAttach_ReportTypeSqlView
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
	End Sub
	
	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
