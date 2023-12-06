Imports System.Net
Imports System.Web.Http

Public Class ValuesController
    Inherits ApiController

    Private ReadOnly _service As IService

    Public Sub New(service As IService)
        _service = service
    End Sub

    ' GET api/<controller>

    '<HttpGet>
    'Public Function GetValues() As IHttpActionResult
    '    Dim list As List(Of Product) = _service.GetAll()
    '    Return Ok(list)
    'End Function

    ' GET api/<controller>/5
    Public Function GetValue(ByVal id As Integer) As String
        Return "value"
    End Function

    ' POST api/<controller>
    <HttpPost>
    Public Function PostValue(<FromBody> ByVal product As PostProduct) As IHttpActionResult

        _service.InsertProduct(product)
        Return Ok()
    End Function

    ' PUT api/<controller>/5
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/<controller>/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
