Public Interface IService
    Function GetAll() As IEnumerable(Of Product)
    Sub InsertProduct(product As Product)

End Interface
