Imports System.Net
Imports System.Web.Http
Imports System.Web.Mvc

Namespace Controllers
    Public Class DefaultController
        Inherits ApiController
        Private ReadOnly _service As IService

        Public Sub New(service As IService)
            _service = service
        End Sub

        Public Function GetAll() As ActionResult
            Dim list As  = _service.GetAll()
        End Function
    End Class
End Namespace