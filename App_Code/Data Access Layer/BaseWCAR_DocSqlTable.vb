﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in WCAR_DocSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="WCAR_DocSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WCAR_DocTable"></see> class.
''' </remarks>
''' <seealso cref="WCAR_DocTable"></seealso>
''' <seealso cref="WCAR_DocSqlTable"></seealso>

Public Class BaseWCAR_DocSqlTable
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
