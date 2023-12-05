Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class mig1
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Products",
                Function(c) New With
                    {
                        .Id = c.Long(nullable := False, identity := True),
                        .Name = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.Products")
        End Sub
    End Class
End Namespace
