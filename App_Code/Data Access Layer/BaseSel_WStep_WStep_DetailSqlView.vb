' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_WStep_WStep_DetailSqlView.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="Sel_WStep_WStep_DetailSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_WStep_WStep_DetailView"></see> class.
''' </remarks>
''' <seealso cref="Sel_WStep_WStep_DetailView"></seealso>
''' <seealso cref="Sel_WStep_WStep_DetailSqlView"></seealso>

Public Class BaseSel_WStep_WStep_DetailSqlView
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
