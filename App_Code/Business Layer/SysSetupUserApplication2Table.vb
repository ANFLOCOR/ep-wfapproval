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
''' See <see cref="BaseSysSetupUserApplication2Table"></see> for additional information.
''' </summary>
''' <remarks>
''' See <see cref="BaseSysSetupUserApplication2Table"></see> for additional information.
''' <para>
''' This class is implemented using the Singleton design pattern.
''' </para>
''' <para>
''' This is a "safe" class, meaning that it is generated once and never overwritten. 
''' Any changes you make to this class will be preserved when you regenerate your application.
''' </para>
''' </remarks>
''' <seealso cref="BaseSysSetupUserApplication2Table"></seealso>
''' <seealso cref="BaseSysSetupUserApplication2SqlTable"></seealso>
''' <seealso cref="SysSetupUserApplication2SqlTable"></seealso>
''' <seealso cref="SysSetupUserApplication2Definition"></seealso>
''' <seealso cref="SysSetupUserApplication2Record"></seealso>
''' <seealso cref="BaseSysSetupUserApplication2Record"></seealso>

<Serializable()> Public Class SysSetupUserApplication2Table
    Inherits BaseSysSetupUserApplication2Table
    Implements System.Runtime.Serialization.ISerializable, ISingleton


#Region "ISerializable Members"

    ''' <summary>
    ''' Overridden to use the <see cref="SysSetupUserApplication2Table_SerializationHelper"></see> class 
    ''' for deserialization of <see cref="SysSetupUserApplication2Table"></see> data.
    ''' </summary>
    ''' <remarks>
    ''' Since the <see cref="SysSetupUserApplication2Table"></see> class is implemented using the Singleton design pattern, 
    ''' this method must be overridden to prevent additional instances from being created during deserialization.
    ''' </remarks>
    Protected Overridable Sub GetObjectData( _
        ByVal info As System.Runtime.Serialization.SerializationInfo, _
        ByVal context As System.Runtime.Serialization.StreamingContext _
    ) Implements System.Runtime.Serialization.ISerializable.GetObjectData
        info.SetType(GetType(SysSetupUserApplication2Table_SerializationHelper)) 'No other values need to be added
    End Sub

#Region "Class SysSetupUserApplication2Table_SerializationHelper"

    <Serializable()> Private Class SysSetupUserApplication2Table_SerializationHelper
        Implements System.Runtime.Serialization.IObjectReference

        'Method called after this object is deserialized
        Public Function GetRealObject(ByVal context As System.Runtime.Serialization.StreamingContext) As Object _
        Implements System.Runtime.Serialization.IObjectReference.GetRealObject
            Return SysSetupUserApplication2Table.Instance
        End Function
    End Class

#End Region

#End Region

    ''' <summary>
    ''' References the only instance of the <see cref="SysSetupUserApplication2Table"></see> class.
    ''' </summary>
    ''' <remarks>
    ''' Since the <see cref="SysSetupUserApplication2Table"></see> class is implemented using the Singleton design pattern, 
    ''' this field is the only way to access an instance of the class.
    ''' </remarks>
    Public Shared ReadOnly Instance As New SysSetupUserApplication2Table()

    Public Sub New()
        MyBase.New()
    End Sub

End Class ' SysSetupUserApplication2Table
End Namespace
