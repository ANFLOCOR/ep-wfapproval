﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_WASP_User1SqlView.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="Sel_WASP_User1SqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_WASP_User1View"></see> class.
''' </remarks>
''' <seealso cref="Sel_WASP_User1View"></seealso>
''' <seealso cref="Sel_WASP_User1SqlView"></seealso>

Public Class BaseSel_WASP_User1SqlView
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
