Imports AutoMapper
Imports AutoMapper.EquivalencyExpression
Imports Models


Public Class ConfigurationMappingProfile
    Inherits Profile

    Public Sub New()
        CreateMap(Of ItemDto, ItemModel)().
            EqualityComparison(Function(config, model) config.Name = model.CommandName).
            ForMember(Function(d) d.CommandName, Sub(opt) opt.MapFrom(Function(s) s.Name)).
            ReverseMap()
    End Sub

End Class
