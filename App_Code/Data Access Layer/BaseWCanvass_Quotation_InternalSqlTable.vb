﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in WCanvass_Quotation_InternalSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="WCanvass_Quotation_InternalSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WCanvass_Quotation_InternalTable"></see> class.
''' </remarks>
''' <seealso cref="WCanvass_Quotation_InternalTable"></seealso>
''' <seealso cref="WCanvass_Quotation_InternalSqlTable"></seealso>

Public Class BaseWCanvass_Quotation_InternalSqlTable
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
