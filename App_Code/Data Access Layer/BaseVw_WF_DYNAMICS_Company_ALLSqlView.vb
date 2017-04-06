' This class is "generated" and will be overwritten.
' Your customizations should be made in Vw_WF_DYNAMICS_Company_ALLSqlView.vb  

Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="Vw_WF_DYNAMICS_Company_ALLSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Vw_WF_DYNAMICS_Company_ALLView"></see> class.
''' </remarks>
''' <seealso cref="Vw_WF_DYNAMICS_Company_ALLView"></seealso>
''' <seealso cref="Vw_WF_DYNAMICS_Company_ALLSqlView"></seealso>

Public Class BaseVw_WF_DYNAMICS_Company_ALLSqlView
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
	End Sub
	
	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
