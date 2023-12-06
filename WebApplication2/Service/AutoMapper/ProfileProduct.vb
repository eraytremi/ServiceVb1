Imports AutoMapper
Module ProfileProduct

    Dim config As New MapperConfiguration(Sub(cfg)
                                              cfg.CreateMap(Of Product, PostProduct)()
                                          End Sub)
    Dim mapper As IMapper = config.CreateMapper()
End Module
