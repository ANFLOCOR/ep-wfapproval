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
''' See <see cref="BaseSysSetupUserPermission2Table"></see> for additional information.
''' </summary>
''' <remarks>
''' See <see cref="BaseSysSetupUserPermission2Table"></see> for additional information.
''' <para>
''' This class is implemented using the Singleton design pattern.
''' </para>
''' <para>
''' This is a "safe" class, meaning that it is generated once and never overwritten. 
''' Any changes you make to this class will be preserved when you regenerate your application.
''' </para>
''' </remarks>
''' <seealso cref="BaseSysSetupUserPermission2Table"></seealso>
''' <seealso cref="BaseSysSetupUserPermission2SqlTable"></seealso>
''' <seealso cref="SysSetupUserPermission2SqlTable"></seealso>
''' <seealso cref="SysSetupUserPermission2Definition"></seealso>
''' <seealso cref="SysSetupUserPermission2Record"></seealso>
''' <seealso cref="BaseSysSetupUserPermission2Record"></seealso>

<Serializable()> Public Class SysSetupUserPermission2Table
    Inherits BaseSysSetupUserPermission2Table
    Implements System.Runtime.Serialization.ISerializable, ISingleton


#Region "ISerializable Members"

    ''' <summary>
    ''' Overridden to use the <see cref="SysSetupUserPermission2Table_SerializationHelper"></see> class 
    ''' for deserialization of <see cref="SysSetupUserPermission2Table"></see> data.
    ''' </summary>
    ''' <remarks>
    ''' Since the <see cref="SysSetupUserPermission2Table"></see> class is implemented using the Singleton design pattern, 
    ''' this method must be overridden to prevent additional instances from being created during deserialization.
    ''' </remarks>
    Protected Overridable Sub GetObjectData( _
        ByVal info As System.Runtime.Serialization.SerializationInfo, _
        ByVal context As System.Runtime.Serialization.StreamingContext _
    ) Implements System.Runtime.Serialization.ISerializable.GetObjectData
        info.SetType(GetType(SysSetupUserPermission2Table_SerializationHelper)) 'No other values need to be added
    End Sub

#Region "Class SysSetupUserPermission2Table_SerializationHelper"

    <Serializable()> Private Class SysSetupUserPermission2Table_SerializationHelper
        Implements System.Runtime.Serialization.IObjectReference

        'Method called after this object is deserialized
        Public Function GetRealObject(ByVal context As System.Runtime.Serialization.StreamingContext) As Object _
        Implements System.Runtime.Serialization.IObjectReference.GetRealObject
            Return SysSetupUserPermission2Table.Instance
        End Function
    End Class

#End Region

#End Region

    ''' <summary>
    ''' References the only instance of the <see cref="SysSetupUserPermission2Table"></see> class.
    ''' </summary>
    ''' <remarks>
    ''' Since the <see cref="SysSetupUserPermission2Table"></see> class is implemented using the Singleton design pattern, 
    ''' this field is the only way to access an instance of the class.
    ''' </remarks>
    Public Shared ReadOnly Instance As New SysSetupUserPermission2Table()

    Public Sub New()
        MyBase.New()
    End Sub

End Class ' SysSetupUserPermission2Table
End Namespace
