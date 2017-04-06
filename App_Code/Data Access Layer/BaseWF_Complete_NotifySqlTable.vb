' This class is "generated" and will be overwritten.
' Your customizations should be made in WF_Complete_NotifySqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="WF_Complete_NotifySqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WF_Complete_NotifyTable"></see> class.
''' </remarks>
''' <seealso cref="WF_Complete_NotifyTable"></seealso>
''' <seealso cref="WF_Complete_NotifySqlTable"></seealso>

Public Class BaseWF_Complete_NotifySqlTable
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
