' This class is "generated" and will be overwritten.
' Your customizations should be made in WPOP101001SqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="WPOP101001SqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WPOP101001Table"></see> class.
''' </remarks>
''' <seealso cref="WPOP101001Table"></seealso>
''' <seealso cref="WPOP101001SqlTable"></seealso>

Public Class BaseWPOP101001SqlTable
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
