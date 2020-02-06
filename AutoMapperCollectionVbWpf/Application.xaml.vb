Imports AutoMapper
Imports AutoMapper.EquivalencyExpression

Class Application

    ' Application-level events, such as Startup, Exit, and DispatcherUnhandledException
    ' can be handled in this file.
    Private Sub New()
        Dim mapperCfg = New MapperConfiguration(
            Sub(cfg)
                cfg.AddCollectionMappers()
                cfg.AddProfile(Of ConfigurationMappingProfile)()
            End Sub)
    End Sub

End Class
