Public Class Service
    Implements IService

    Public Sub GetAll() Implements IService.GetAll
        Using context As New Context()
            context.Products.ToList()
        End Using
    End Sub

    Public Sub InsertProduct(product As Product) Implements IService.InsertProduct
        Using context As New Context()
            context.Products.Add(product)
            context.SaveChanges()
        End Using
    End Sub
End Class
