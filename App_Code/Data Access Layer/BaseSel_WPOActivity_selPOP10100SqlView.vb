﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_WPOActivity_selPOP10100SqlView.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="Sel_WPOActivity_selPOP10100SqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_WPOActivity_selPOP10100View"></see> class.
''' </remarks>
''' <seealso cref="Sel_WPOActivity_selPOP10100View"></seealso>
''' <seealso cref="Sel_WPOActivity_selPOP10100SqlView"></seealso>

Public Class BaseSel_WPOActivity_selPOP10100SqlView
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
