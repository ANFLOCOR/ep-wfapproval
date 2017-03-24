' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_IV407001SqlView.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="Sel_IV407001SqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_IV407001View"></see> class.
''' </remarks>
''' <seealso cref="Sel_IV407001View"></seealso>
''' <seealso cref="Sel_IV407001SqlView"></seealso>

Public Class BaseSel_IV407001SqlView
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
