﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in WTask_Delegation1SqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="WTask_Delegation1SqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WTask_Delegation1Table"></see> class.
''' </remarks>
''' <seealso cref="WTask_Delegation1Table"></seealso>
''' <seealso cref="WTask_Delegation1SqlTable"></seealso>

Public Class BaseWTask_Delegation1SqlTable
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
