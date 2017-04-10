﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in CFBS_CategoryMappingSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="CFBS_CategoryMappingSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="CFBS_CategoryMappingTable"></see> class.
''' </remarks>
''' <seealso cref="CFBS_CategoryMappingTable"></seealso>
''' <seealso cref="CFBS_CategoryMappingSqlTable"></seealso>

Public Class BaseCFBS_CategoryMappingSqlTable
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace