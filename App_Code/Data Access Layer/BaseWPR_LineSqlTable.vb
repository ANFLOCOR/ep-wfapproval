﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in WPR_LineSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="WPR_LineSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WPR_LineTable"></see> class.
''' </remarks>
''' <seealso cref="WPR_LineTable"></seealso>
''' <seealso cref="WPR_LineSqlTable"></seealso>

Public Class BaseWPR_LineSqlTable
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
