Imports System.Configuration

Public Class ItemDto
    Inherits ConfigurationElement

#Region " Name property "

    <ConfigurationProperty(NameOf(Name), IsKey:=True)>
    Public Property Name As String
        Get
            Return CStr(Me(NameOf(Name)))
        End Get
        Set(value As String)
            Me(NameOf(Name)) = value
        End Set
    End Property

#End Region


#Region " RecognitionText property "

    <ConfigurationProperty(NameOf(RecognitionText))>
    Public Property RecognitionText As String
        Get
            Return CStr(Me(NameOf(RecognitionText)))
        End Get
        Set(value As String)
            Me(NameOf(RecognitionText)) = value
        End Set
    End Property

#End Region


#Region " AccessKey property "

    <ConfigurationProperty(NameOf(AccessKey))>
    Public Property AccessKey As String
        Get
            Return CStr(Me(NameOf(AccessKey)))
        End Get
        Set(value As String)
            Me(NameOf(AccessKey)) = value
        End Set
    End Property

#End Region

End Class
