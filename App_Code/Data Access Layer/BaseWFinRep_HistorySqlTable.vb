﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in WFinRep_HistorySqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="WFinRep_HistorySqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WFinRep_HistoryTable"></see> class.
''' </remarks>
''' <seealso cref="WFinRep_HistoryTable"></seealso>
''' <seealso cref="WFinRep_HistorySqlTable"></seealso>

Public Class BaseWFinRep_HistorySqlTable
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
