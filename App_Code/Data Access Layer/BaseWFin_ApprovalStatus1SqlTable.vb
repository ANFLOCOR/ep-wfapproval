﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in WFin_ApprovalStatus1SqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="WFin_ApprovalStatus1SqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WFin_ApprovalStatus1Table"></see> class.
''' </remarks>
''' <seealso cref="WFin_ApprovalStatus1Table"></seealso>
''' <seealso cref="WFin_ApprovalStatus1SqlTable"></seealso>

Public Class BaseWFin_ApprovalStatus1SqlTable
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
