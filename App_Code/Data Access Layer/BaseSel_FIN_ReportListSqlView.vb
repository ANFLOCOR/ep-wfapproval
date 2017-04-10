' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_FIN_ReportListSqlView.vb  

Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="Sel_FIN_ReportListSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_FIN_ReportListView"></see> class.
''' </remarks>
''' <seealso cref="Sel_FIN_ReportListView"></seealso>
''' <seealso cref="Sel_FIN_ReportListSqlView"></seealso>

Public Class BaseSel_FIN_ReportListSqlView
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
	End Sub
	
	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
