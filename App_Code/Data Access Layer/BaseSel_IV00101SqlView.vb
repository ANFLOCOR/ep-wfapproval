﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_IV00101SqlView.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="Sel_IV00101SqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_IV00101View"></see> class.
''' </remarks>
''' <seealso cref="Sel_IV00101View"></seealso>
''' <seealso cref="Sel_IV00101SqlView"></seealso>

Public Class BaseSel_IV00101SqlView
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
