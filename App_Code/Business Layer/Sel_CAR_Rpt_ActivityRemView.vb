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
''' See <see cref="BaseSel_CAR_Rpt_ActivityRemView"></see> for additional information.
''' </summary>
''' <remarks>
''' See <see cref="BaseSel_CAR_Rpt_ActivityRemView"></see> for additional information.
''' <para>
''' This class is implemented using the Singleton design pattern.
''' </para>
''' </remarks>
''' <seealso cref="BaseSel_CAR_Rpt_ActivityRemView"></seealso>
''' <seealso cref="BaseSel_CAR_Rpt_ActivityRemSqlView"></seealso>
''' <seealso cref="Sel_CAR_Rpt_ActivityRemSqlView"></seealso>
''' <seealso cref="Sel_CAR_Rpt_ActivityRemDefinition"></seealso>
''' <seealso cref="Sel_CAR_Rpt_ActivityRemRecord"></seealso>
''' <seealso cref="BaseSel_CAR_Rpt_ActivityRemRecord"></seealso>

<Serializable()> Public Class Sel_CAR_Rpt_ActivityRemView
	Inherits BaseSel_CAR_Rpt_ActivityRemView
	Implements System.Runtime.Serialization.ISerializable, ISingleton


#Region "ISerializable Members"

	''' <summary>
	''' Overridden to use the <see cref="Sel_CAR_Rpt_ActivityRemView_SerializationHelper"></see> class 
	''' for deserialization of <see cref="Sel_CAR_Rpt_ActivityRemView"></see> data.
	''' </summary>
	''' <remarks>
	''' Since the <see cref="Sel_CAR_Rpt_ActivityRemView"></see> class is implemented using the Singleton design pattern, 
	''' this method must be overridden to prevent additional instances from being created during deserialization.
	''' </remarks>
	Protected Overridable Sub GetObjectData( _
		ByVal info As System.Runtime.Serialization.SerializationInfo, _
		ByVal context As System.Runtime.Serialization.StreamingContext _
	) Implements System.Runtime.Serialization.ISerializable.GetObjectData
		info.SetType(GetType(Sel_CAR_Rpt_ActivityRemView_SerializationHelper)) 'No other values need to be added
	End Sub

#Region "Class Sel_CAR_Rpt_ActivityRemView_SerializationHelper"

	<Serializable()> Private Class Sel_CAR_Rpt_ActivityRemView_SerializationHelper
		Implements System.Runtime.Serialization.IObjectReference

		'Method called after this object is deserialized
		Public Function GetRealObject(ByVal context As System.Runtime.Serialization.StreamingContext) As Object _
		Implements System.Runtime.Serialization.IObjectReference.GetRealObject
			Return Sel_CAR_Rpt_ActivityRemView.Instance
		End Function
	End Class

#End Region

#End Region

	''' <summary>
	''' References the only instance of the <see cref="Sel_CAR_Rpt_ActivityRemView"></see> class.
	''' </summary>
	''' <remarks>
	''' Since the <see cref="Sel_CAR_Rpt_ActivityRemView"></see> class is implemented using the Singleton design pattern, 
	''' this field is the only way to access an instance of the class.
	''' </remarks>
	Public Shared ReadOnly Instance As New Sel_CAR_Rpt_ActivityRemView()

	Public Sub New()
		MyBase.New()
	End Sub


End Class
End Namespace
