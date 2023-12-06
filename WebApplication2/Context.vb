Imports System.Data.Entity
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Context
    Inherits DbContext

    Public Property Products As DbSet(Of Product)
    Public Property Categories As DbSet(Of Category)

    Public Sub New()
        MyBase.New(ConfigurationManager.ConnectionStrings("Context").ConnectionString)
        Database.SetInitializer(Of Context)(Nothing)
    End Sub
End Class
