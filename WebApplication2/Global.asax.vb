Imports System.Web.Http
Imports Autofac
Imports Autofac.Integration.WebApi

Public Class WebApiApplication
    Inherits System.Web.HttpApplication

    Private container As IContainer

    Protected Sub Application_Start()
        container = ConfigureContainer()
        GlobalConfiguration.Configure(AddressOf Register)
    End Sub

    Public Sub Register(ByVal config As HttpConfiguration)

        config.DependencyResolver = New AutofacWebApiDependencyResolver(container)

        config.MapHttpAttributeRoutes()

        config.Routes.MapHttpRoute(
            name:="DefaultApi",
            routeTemplate:="api/{controller}/{id}",
            defaults:=New With {.id = RouteParameter.Optional}
        )
    End Sub

    Private Function ConfigureContainer() As IContainer
        Dim builder As New ContainerBuilder()
        builder.RegisterType(Of Context)().InstancePerLifetimeScope()
        builder.RegisterType(Of Service)().As(Of IService)().InstancePerLifetimeScope()
        builder.RegisterApiControllers(Reflection.Assembly.GetExecutingAssembly())

        Return builder.Build()
    End Function
End Class
