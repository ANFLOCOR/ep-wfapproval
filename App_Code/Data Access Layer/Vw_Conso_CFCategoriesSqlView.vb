﻿' This is a "safe" class, meaning that it is created once 
' and never overwritten. Any custom code you add to this class 
' will be preserved when you regenerate your application.
'
' Typical customizations that may be done in this class include
'  - overriding base class methods

Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Data

''' <summary>
''' Used by the <see cref="Vw_Conso_CFCategoriesView"></see> class to access and/or modify the database.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Vw_Conso_CFCategoriesView"></see> class.
''' <para>
''' This is a "safe" class, meaning that it is generated once and never overwritten. 
''' Any changes you make to this class will be preserved when you regenerate your application.
''' </para>
''' </remarks>
''' <seealso cref="Vw_Conso_CFCategoriesView"></seealso>

Public Class Vw_Conso_CFCategoriesSqlView
	Inherits BaseVw_Conso_CFCategoriesSqlView
	
	'The functions below may be overridden in order to implement your own
	'logic for running queries that return lists of records.  
	
End Class
End Namespace
