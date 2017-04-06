' This class is "generated" and will be overwritten.
' Your customizations should be made in WPO_Step_WPO_StepDetail_WASPSqlView.vb  

Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="WPO_Step_WPO_StepDetail_WASPSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WPO_Step_WPO_StepDetail_WASPView"></see> class.
''' </remarks>
''' <seealso cref="WPO_Step_WPO_StepDetail_WASPView"></seealso>
''' <seealso cref="WPO_Step_WPO_StepDetail_WASPSqlView"></seealso>

Public Class BaseWPO_Step_WPO_StepDetail_WASPSqlView
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
	End Sub
	
	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
