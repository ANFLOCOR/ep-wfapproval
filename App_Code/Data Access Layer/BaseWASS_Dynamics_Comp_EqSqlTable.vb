' This class is "generated" and will be overwritten.
' Your customizations should be made in WASS_Dynamics_Comp_EqSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="WASS_Dynamics_Comp_EqSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WASS_Dynamics_Comp_EqTable"></see> class.
''' </remarks>
''' <seealso cref="WASS_Dynamics_Comp_EqTable"></seealso>
''' <seealso cref="WASS_Dynamics_Comp_EqSqlTable"></seealso>

Public Class BaseWASS_Dynamics_Comp_EqSqlTable
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
