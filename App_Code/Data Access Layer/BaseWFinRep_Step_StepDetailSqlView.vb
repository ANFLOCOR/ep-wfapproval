' This class is "generated" and will be overwritten.
' Your customizations should be made in WFinRep_Step_StepDetailSqlView.vb  

Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="WFinRep_Step_StepDetailSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WFinRep_Step_StepDetailView"></see> class.
''' </remarks>
''' <seealso cref="WFinRep_Step_StepDetailView"></seealso>
''' <seealso cref="WFinRep_Step_StepDetailSqlView"></seealso>

Public Class BaseWFinRep_Step_StepDetailSqlView
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
	End Sub
	
	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
