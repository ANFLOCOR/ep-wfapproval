﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in WCanvass_PO_MapSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="WCanvass_PO_MapSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WCanvass_PO_MapTable"></see> class.
''' </remarks>
''' <seealso cref="WCanvass_PO_MapTable"></seealso>
''' <seealso cref="WCanvass_PO_MapSqlTable"></seealso>

Public Class BaseWCanvass_PO_MapSqlTable
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
