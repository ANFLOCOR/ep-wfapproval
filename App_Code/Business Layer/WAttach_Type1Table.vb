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
''' See <see cref="BaseWAttach_Type1Table"></see> for additional information.
''' </summary>
''' <remarks>
''' See <see cref="BaseWAttach_Type1Table"></see> for additional information.
''' <para>
''' This class is implemented using the Singleton design pattern.
''' </para>
''' <para>
''' This is a "safe" class, meaning that it is generated once and never overwritten. 
''' Any changes you make to this class will be preserved when you regenerate your application.
''' </para>
''' </remarks>
''' <seealso cref="BaseWAttach_Type1Table"></seealso>
''' <seealso cref="BaseWAttach_Type1SqlTable"></seealso>
''' <seealso cref="WAttach_Type1SqlTable"></seealso>
''' <seealso cref="WAttach_Type1Definition"></seealso>
''' <seealso cref="WAttach_Type1Record"></seealso>
''' <seealso cref="BaseWAttach_Type1Record"></seealso>

<Serializable()> Public Class WAttach_Type1Table
    Inherits BaseWAttach_Type1Table
    Implements System.Runtime.Serialization.ISerializable, ISingleton


#Region "ISerializable Members"

    ''' <summary>
    ''' Overridden to use the <see cref="WAttach_Type1Table_SerializationHelper"></see> class 
    ''' for deserialization of <see cref="WAttach_Type1Table"></see> data.
    ''' </summary>
    ''' <remarks>
    ''' Since the <see cref="WAttach_Type1Table"></see> class is implemented using the Singleton design pattern, 
    ''' this method must be overridden to prevent additional instances from being created during deserialization.
    ''' </remarks>
    Protected Overridable Sub GetObjectData( _
        ByVal info As System.Runtime.Serialization.SerializationInfo, _
        ByVal context As System.Runtime.Serialization.StreamingContext _
    ) Implements System.Runtime.Serialization.ISerializable.GetObjectData
        info.SetType(GetType(WAttach_Type1Table_SerializationHelper)) 'No other values need to be added
    End Sub

#Region "Class WAttach_Type1Table_SerializationHelper"

    <Serializable()> Private Class WAttach_Type1Table_SerializationHelper
        Implements System.Runtime.Serialization.IObjectReference

        'Method called after this object is deserialized
        Public Function GetRealObject(ByVal context As System.Runtime.Serialization.StreamingContext) As Object _
        Implements System.Runtime.Serialization.IObjectReference.GetRealObject
            Return WAttach_Type1Table.Instance
        End Function
    End Class

#End Region

#End Region

    ''' <summary>
    ''' References the only instance of the <see cref="WAttach_Type1Table"></see> class.
    ''' </summary>
    ''' <remarks>
    ''' Since the <see cref="WAttach_Type1Table"></see> class is implemented using the Singleton design pattern, 
    ''' this field is the only way to access an instance of the class.
    ''' </remarks>
    Public Shared ReadOnly Instance As New WAttach_Type1Table()

    Public Sub New()
        MyBase.New()
    End Sub

End Class ' WAttach_Type1Table
End Namespace
