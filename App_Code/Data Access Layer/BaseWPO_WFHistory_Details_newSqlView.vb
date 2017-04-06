' This class is "generated" and will be overwritten.
' Your customizations should be made in WPO_WFHistory_Details_newSqlView.vb  

Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="WPO_WFHistory_Details_newSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WPO_WFHistory_Details_newView"></see> class.
''' </remarks>
''' <seealso cref="WPO_WFHistory_Details_newView"></seealso>
''' <seealso cref="WPO_WFHistory_Details_newSqlView"></seealso>

Public Class BaseWPO_WFHistory_Details_newSqlView
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
	End Sub
	
	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
