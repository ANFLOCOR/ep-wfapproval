﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in W_User_DYNAMICS_CompanySqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="W_User_DYNAMICS_CompanySqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="W_User_DYNAMICS_CompanyTable"></see> class.
''' </remarks>
''' <seealso cref="W_User_DYNAMICS_CompanyTable"></seealso>
''' <seealso cref="W_User_DYNAMICS_CompanySqlTable"></seealso>

Public Class BaseW_User_DYNAMICS_CompanySqlTable
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
