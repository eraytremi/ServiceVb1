Public Class Service
    Implements IService



    Public Sub InsertProduct(product As Product) Implements IService.InsertProduct
        Using context As New Context()
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
