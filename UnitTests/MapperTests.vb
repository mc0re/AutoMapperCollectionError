Imports AutoMapper
Imports AutoMapper.EquivalencyExpression
Imports MainApp


<TestClass()>
Public Class MapperTests

    <TestMethod>
    Public Sub Mapper_Validate()
        Dim config = New MapperConfiguration(
            Sub(cfg)
                cfg.AddCollectionMappers()
                cfg.AddProfile(Of ConfigurationMappingProfile)()
            End Sub)

        config.AssertConfigurationIsValid()
    End Sub

End Class