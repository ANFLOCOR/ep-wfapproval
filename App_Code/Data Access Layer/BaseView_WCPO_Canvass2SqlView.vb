' This class is "generated" and will be overwritten.
' Your customizations should be made in View_WCPO_Canvass2SqlView.vb  

Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="View_WCPO_Canvass2SqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="View_WCPO_Canvass2View"></see> class.
''' </remarks>
''' <seealso cref="View_WCPO_Canvass2View"></seealso>
''' <seealso cref="View_WCPO_Canvass2SqlView"></seealso>

Public Class BaseView_WCPO_Canvass2SqlView
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
	End Sub
	
	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
