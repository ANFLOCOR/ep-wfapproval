﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_FIN_WASP_ReportSqlView.vb  

Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="Sel_FIN_WASP_ReportSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_FIN_WASP_ReportView"></see> class.
''' </remarks>
''' <seealso cref="Sel_FIN_WASP_ReportView"></seealso>
''' <seealso cref="Sel_FIN_WASP_ReportSqlView"></seealso>

Public Class BaseSel_FIN_WASP_ReportSqlView
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
	End Sub
	
	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace