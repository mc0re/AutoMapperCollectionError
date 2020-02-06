Imports AutoMapper
Imports AutoMapper.EquivalencyExpression
Imports Models


Class MainWindow

    Protected Overrides Sub OnInitialized(e As EventArgs)
        MyBase.OnInitialized(e)

        Dim config = New MapperConfiguration(
            Sub(cfg)
                cfg.AddCollectionMappers()
                cfg.AddProfile(Of ConfigurationMappingProfile)()
            End Sub)

        config.AssertConfigurationIsValid()

        Dim dtos = New List(Of ItemDto) From {New ItemDto With {.Name = "T1", .RecognitionText = "One"}}
        Dim models = config.CreateMapper().Map(Of List(Of ItemModel))(dtos)

        Dim msg = String.Join(Environment.NewLine, From m In models Select $"{m.CommandName}: {m.RecognitionText}")
        OutText.Text = msg
    End Sub
End Class
