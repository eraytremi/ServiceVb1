Imports System.Data.Entity
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Context
    Inherits DbContext
    Public Sub New()
        Database.SetInitializer(New MigrateDatabaseToLatestVersion(Of Context, Migrations.Configuration))
    End Sub
    Public Property Products As DbSet(Of Product)
    Public Property Categories As DbSet(Of Category)


    Public Sub New(connectionString As String)
        MyBase.New(connectionString)
    End Sub
End Class
