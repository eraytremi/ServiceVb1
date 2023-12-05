Imports System.Web.Http
Imports Autofac
Imports Autofac.Core

Public Class WebApiApplication
    Inherits System.Web.HttpApplication

    Private _container As Container

    Private Sub InitializeContainer()

        Dim builder As New ContainerBuilder()

        builder.RegisterType(Of Service).As(Of IService)()

        _container = builder.Build()

    End Sub
    Protected Sub Application_Start()
        GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
    End Sub
End Class
