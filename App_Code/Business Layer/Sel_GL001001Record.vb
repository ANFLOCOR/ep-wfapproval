' This is a "safe" class, meaning that it is created once 
' and never overwritten. Any custom code you add to this class 
' will be preserved when you regenerate your application.
'
' Typical customizations that may be done in this class include
'  - adding custom event handlers
'  - overriding base class methods

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' Provides access to the data in a database record.
''' Also provides access to the <see cref="Sel_GL001001View"></see> that each record is associated with.
''' </summary>
''' <remarks>
''' </remarks>
''' <seealso cref="Sel_GL001001View"></seealso>

<Serializable()> Public Class Sel_GL001001Record
	Inherits BaseSel_GL001001Record

	' Constructors
	
	Public Sub New()
		MyBase.New()
	End Sub
	
	

	

End Class
End Namespace
