﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in WTask_DelegationSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="WTask_DelegationSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WTask_DelegationTable"></see> class.
''' </remarks>
''' <seealso cref="WTask_DelegationTable"></seealso>
''' <seealso cref="WTask_DelegationSqlTable"></seealso>

Public Class BaseWTask_DelegationSqlTable
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
