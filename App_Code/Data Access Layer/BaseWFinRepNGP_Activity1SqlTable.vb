﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in WFinRepNGP_Activity1SqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="WFinRepNGP_Activity1SqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WFinRepNGP_Activity1Table"></see> class.
''' </remarks>
''' <seealso cref="WFinRepNGP_Activity1Table"></seealso>
''' <seealso cref="WFinRepNGP_Activity1SqlTable"></seealso>

Public Class BaseWFinRepNGP_Activity1SqlTable
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace