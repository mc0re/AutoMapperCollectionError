Public Class ItemModel

#Region " Properties "

    Public Property CommandName As String


    Public Property ParameterType As CommandParameterTypes


    Public Property IsEnabled As Boolean


    Public Property IsRecognitionEnabled As Boolean


    Public Property RecognitionText As String


    Public Property AccessKey As String

#End Region


#Region " Init and clean-up "

    ''' <summary>
    ''' Default constructor for serialization.
    ''' </summary>
    Public Sub New()
        ' Do nothing
    End Sub


    ''' <summary>
    ''' Create a new disabled setting.
    ''' </summary>
    ''' <param name="cmdName">System-defined command name (e.g. StopCommand)</param>
    ''' <param name="recText">Text for voice recognition</param>
    Public Sub New(cmdName As String, recText As String)
        CommandName = cmdName
        RecognitionText = recText
        IsEnabled = True
        IsRecognitionEnabled = False
    End Sub

#End Region


#Region " ToString "

    Public Overrides Function ToString() As String
        Return String.Format("{0}{1} = {2}",
                             If(IsRecognitionEnabled, "+", "-"), CommandName, RecognitionText)
    End Function

#End Region

End Class
