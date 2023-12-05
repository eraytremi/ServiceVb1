Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class mig2
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Categories",
                Function(c) New With
                    {
                        .Id = c.Short(nullable := False, identity := True),
                        .Name = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            AddColumn("dbo.Products", "Category_Id", Function(c) c.Short())
            CreateIndex("dbo.Products", "Category_Id")
            AddForeignKey("dbo.Products", "Category_Id", "dbo.Categories", "Id")
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Products", "Category_Id", "dbo.Categories")
            DropIndex("dbo.Products", New String() { "Category_Id" })
            DropColumn("dbo.Products", "Category_Id")
            DropTable("dbo.Categories")
        End Sub
    End Class
End Namespace
