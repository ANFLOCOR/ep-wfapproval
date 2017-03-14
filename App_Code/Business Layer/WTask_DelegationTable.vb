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
''' See <see cref="BaseWTask_DelegationTable"></see> for additional information.
''' </summary>
''' <remarks>
''' See <see cref="BaseWTask_DelegationTable"></see> for additional information.
''' <para>
''' This class is implemented using the Singleton design pattern.
''' </para>
''' <para>
''' This is a "safe" class, meaning that it is generated once and never overwritten. 
''' Any changes you make to this class will be preserved when you regenerate your application.
''' </para>
''' </remarks>
''' <seealso cref="BaseWTask_DelegationTable"></seealso>
''' <seealso cref="BaseWTask_DelegationSqlTable"></seealso>
''' <seealso cref="WTask_DelegationSqlTable"></seealso>
''' <seealso cref="WTask_DelegationDefinition"></seealso>
''' <seealso cref="WTask_DelegationRecord"></seealso>
''' <seealso cref="BaseWTask_DelegationRecord"></seealso>

<Serializable()> Public Class WTask_DelegationTable
    Inherits BaseWTask_DelegationTable
    Implements System.Runtime.Serialization.ISerializable, ISingleton


#Region "ISerializable Members"

    ''' <summary>
    ''' Overridden to use the <see cref="WTask_DelegationTable_SerializationHelper"></see> class 
    ''' for deserialization of <see cref="WTask_DelegationTable"></see> data.
    ''' </summary>
    ''' <remarks>
    ''' Since the <see cref="WTask_DelegationTable"></see> class is implemented using the Singleton design pattern, 
    ''' this method must be overridden to prevent additional instances from being created during deserialization.
    ''' </remarks>
    Protected Overridable Sub GetObjectData( _
        ByVal info As System.Runtime.Serialization.SerializationInfo, _
        ByVal context As System.Runtime.Serialization.StreamingContext _
    ) Implements System.Runtime.Serialization.ISerializable.GetObjectData
        info.SetType(GetType(WTask_DelegationTable_SerializationHelper)) 'No other values need to be added
    End Sub

#Region "Class WTask_DelegationTable_SerializationHelper"

    <Serializable()> Private Class WTask_DelegationTable_SerializationHelper
        Implements System.Runtime.Serialization.IObjectReference

        'Method called after this object is deserialized
        Public Function GetRealObject(ByVal context As System.Runtime.Serialization.StreamingContext) As Object _
        Implements System.Runtime.Serialization.IObjectReference.GetRealObject
            Return WTask_DelegationTable.Instance
        End Function
    End Class

#End Region

#End Region

    ''' <summary>
    ''' References the only instance of the <see cref="WTask_DelegationTable"></see> class.
    ''' </summary>
    ''' <remarks>
    ''' Since the <see cref="WTask_DelegationTable"></see> class is implemented using the Singleton design pattern, 
    ''' this field is the only way to access an instance of the class.
    ''' </remarks>
    Public Shared ReadOnly Instance As New WTask_DelegationTable()

    Public Sub New()
        MyBase.New()
    End Sub

End Class ' WTask_DelegationTable
End Namespace
