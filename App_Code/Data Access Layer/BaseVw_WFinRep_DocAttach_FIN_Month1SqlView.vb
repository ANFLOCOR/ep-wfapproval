' This class is "generated" and will be overwritten.
' Your customizations should be made in Vw_WFinRep_DocAttach_FIN_Month1SqlView.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="Vw_WFinRep_DocAttach_FIN_Month1SqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Vw_WFinRep_DocAttach_FIN_Month1View"></see> class.
''' </remarks>
''' <seealso cref="Vw_WFinRep_DocAttach_FIN_Month1View"></seealso>
''' <seealso cref="Vw_WFinRep_DocAttach_FIN_Month1SqlView"></seealso>

Public Class BaseVw_WFinRep_DocAttach_FIN_Month1SqlView
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
