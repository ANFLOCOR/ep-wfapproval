' This class is "generated" and will be overwritten.
' Your customizations should be made in Vw_FS_WFinRep_Attachment_PerReportTypeSqlView.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="Vw_FS_WFinRep_Attachment_PerReportTypeSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Vw_FS_WFinRep_Attachment_PerReportTypeView"></see> class.
''' </remarks>
''' <seealso cref="Vw_FS_WFinRep_Attachment_PerReportTypeView"></seealso>
''' <seealso cref="Vw_FS_WFinRep_Attachment_PerReportTypeSqlView"></seealso>

Public Class BaseVw_FS_WFinRep_Attachment_PerReportTypeSqlView
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
