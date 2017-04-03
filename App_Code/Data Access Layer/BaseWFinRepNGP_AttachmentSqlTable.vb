' This class is "generated" and will be overwritten.
' Your customizations should be made in WFinRepNGP_AttachmentSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="WFinRepNGP_AttachmentSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WFinRepNGP_AttachmentTable"></see> class.
''' </remarks>
''' <seealso cref="WFinRepNGP_AttachmentTable"></seealso>
''' <seealso cref="WFinRepNGP_AttachmentSqlTable"></seealso>

Public Class BaseWFinRepNGP_AttachmentSqlTable
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
