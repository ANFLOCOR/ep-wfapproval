' This class is "generated" and will be overwritten.
' Your customizations should be made in WPO_Step_WPO_StepDetailSqlView.vb  

Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="WPO_Step_WPO_StepDetailSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WPO_Step_WPO_StepDetailView"></see> class.
''' </remarks>
''' <seealso cref="WPO_Step_WPO_StepDetailView"></seealso>
''' <seealso cref="WPO_Step_WPO_StepDetailSqlView"></seealso>

Public Class BaseWPO_Step_WPO_StepDetailSqlView
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
	End Sub
	
	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
