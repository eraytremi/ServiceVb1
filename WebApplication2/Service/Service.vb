Imports AutoMapper

Public Class Service
    Implements IService

    Private _mapper As IMapper

    Public Sub New(mapper As IMapper)
        _mapper = mapper
    End Sub

    Public Sub InsertProduct(productPost As PostProduct) Implements IService.InsertProduct
        Using context As New Context()
            Dim product = _mapper.Map(Of Product)(productPost)
            context.Products.Add(product)
            context.SaveChanges()
        End Using
    End Sub

    Public Function GetAll() As IEnumerable(Of Product) Implements IService.GetAll
        Using context As New Context()
            Return context.Products.ToList()
        End Using
    End Function
End Class
