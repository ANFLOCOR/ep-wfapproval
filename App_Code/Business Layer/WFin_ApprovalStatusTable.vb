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
''' Provides access to the schema information and record data of a database table (or view).
''' See <see cref="BaseWFin_ApprovalStatusTable"></see> for additional information.
''' </summary>
''' <remarks>
''' See <see cref="BaseWFin_ApprovalStatusTable"></see> for additional information.
''' <para>
''' This class is implemented using the Singleton design pattern.
''' </para>
''' </remarks>
''' <seealso cref="BaseWFin_ApprovalStatusTable"></seealso>
''' <seealso cref="BaseWFin_ApprovalStatusSqlTable"></seealso>
''' <seealso cref="WFin_ApprovalStatusSqlTable"></seealso>
''' <seealso cref="WFin_ApprovalStatusDefinition"></seealso>
''' <seealso cref="WFin_ApprovalStatusRecord"></seealso>
''' <seealso cref="BaseWFin_ApprovalStatusRecord"></seealso>

<Serializable()> Public Class WFin_ApprovalStatusTable
	Inherits BaseWFin_ApprovalStatusTable
	Implements System.Runtime.Serialization.ISerializable, ISingleton


#Region "ISerializable Members"

	''' <summary>
	''' Overridden to use the <see cref="WFin_ApprovalStatusTable_SerializationHelper"></see> class 
	''' for deserialization of <see cref="WFin_ApprovalStatusTable"></see> data.
	''' </summary>
	''' <remarks>
	''' Since the <see cref="WFin_ApprovalStatusTable"></see> class is implemented using the Singleton design pattern, 
	''' this method must be overridden to prevent additional instances from being created during deserialization.
	''' </remarks>
	Protected Overridable Sub GetObjectData( _
		ByVal info As System.Runtime.Serialization.SerializationInfo, _
		ByVal context As System.Runtime.Serialization.StreamingContext _
	) Implements System.Runtime.Serialization.ISerializable.GetObjectData
		info.SetType(GetType(WFin_ApprovalStatusTable_SerializationHelper)) 'No other values need to be added
	End Sub

#Region "Class WFin_ApprovalStatusTable_SerializationHelper"

	<Serializable()> Private Class WFin_ApprovalStatusTable_SerializationHelper
		Implements System.Runtime.Serialization.IObjectReference

		'Method called after this object is deserialized
		Public Function GetRealObject(ByVal context As System.Runtime.Serialization.StreamingContext) As Object _
		Implements System.Runtime.Serialization.IObjectReference.GetRealObject
			Return WFin_ApprovalStatusTable.Instance
		End Function
	End Class

#End Region

#End Region

	''' <summary>
	''' References the only instance of the <see cref="WFin_ApprovalStatusTable"></see> class.
	''' </summary>
	''' <remarks>
	''' Since the <see cref="WFin_ApprovalStatusTable"></see> class is implemented using the Singleton design pattern, 
	''' this field is the only way to access an instance of the class.
	''' </remarks>
	Public Shared ReadOnly Instance As New WFin_ApprovalStatusTable()

	Public Sub New()
		MyBase.New()
	End Sub


End Class
End Namespace
