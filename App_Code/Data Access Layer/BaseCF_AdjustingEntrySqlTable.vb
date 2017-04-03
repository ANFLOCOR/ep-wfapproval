' This class is "generated" and will be overwritten.
' Your customizations should be made in CF_AdjustingEntrySqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="CF_AdjustingEntrySqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="CF_AdjustingEntryTable"></see> class.
''' </remarks>
''' <seealso cref="CF_AdjustingEntryTable"></seealso>
''' <seealso cref="CF_AdjustingEntrySqlTable"></seealso>

Public Class BaseCF_AdjustingEntrySqlTable
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
