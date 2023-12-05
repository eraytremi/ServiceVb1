Imports System.Net
Imports System.Web.Http

Public Class ValuesController
    Inherits ApiController

    Private ReadOnly _service As IService

    Public Sub New(service As IService)
        _service = service
    End Sub

    ' GET api/<controller>
    <HttpGet>
    Public Function GetValues() As IEnumerable(Of Product)
        Dim list As List(Of Product) = _service.GetAll()
        Return list
    End Function

    ' GET api/<controller>/5
    Public Function GetValue(ByVal id As Integer) As String
        Return "value"
    End Function

    ' POST api/<controller>
    Public Sub PostValue()
        Dim newProduct As New Product
        newProduct.Name="elma"

        _service.InsertProduct(newProduct)

    End Sub

    ' PUT api/<controller>/5
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/<controller>/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
