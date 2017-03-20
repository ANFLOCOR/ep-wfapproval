' This class is "generated" and will be overwritten.
' Your customizations should be made in POP10100_HEADER_ALL2SqlView.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="POP10100_HEADER_ALL2SqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="POP10100_HEADER_ALL2View"></see> class.
''' </remarks>
''' <seealso cref="POP10100_HEADER_ALL2View"></seealso>
''' <seealso cref="POP10100_HEADER_ALL2SqlView"></seealso>

Public Class BasePOP10100_HEADER_ALL2SqlView
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
