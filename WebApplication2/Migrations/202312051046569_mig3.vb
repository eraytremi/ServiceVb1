Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class mig3
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropForeignKey("dbo.Products", "Category_Id", "dbo.Categories")
            DropIndex("dbo.Products", New String() { "Category_Id" })
            RenameColumn(table := "dbo.Products", name := "Category_Id", newName := "CategoryId")
            AlterColumn("dbo.Products", "CategoryId", Function(c) c.Short(nullable := False))
            CreateIndex("dbo.Products", "CategoryId")
            AddForeignKey("dbo.Products", "CategoryId", "dbo.Categories", "Id", cascadeDelete := True)
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories")
            DropIndex("dbo.Products", New String() { "CategoryId" })
            AlterColumn("dbo.Products", "CategoryId", Function(c) c.Short())
            RenameColumn(table := "dbo.Products", name := "CategoryId", newName := "Category_Id")
            CreateIndex("dbo.Products", "Category_Id")
            AddForeignKey("dbo.Products", "Category_Id", "dbo.Categories", "Id")
        End Sub
    End Class
End Namespace
