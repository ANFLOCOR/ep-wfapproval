' This class is "generated" and will be overwritten.
' Your customizations should be made in WPR_Doc_AttachSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="WPR_Doc_AttachSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WPR_Doc_AttachTable"></see> class.
''' </remarks>
''' <seealso cref="WPR_Doc_AttachTable"></seealso>
''' <seealso cref="WPR_Doc_AttachSqlTable"></seealso>

Public Class BaseWPR_Doc_AttachSqlTable
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
