namespace ReSolveTrash.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dongheoq2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Citizens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 15),
                        Password = c.String(nullable: false, maxLength: 45),
                        Email = c.String(nullable: false, maxLength: 62),
                        Name = c.String(nullable: false, maxLength: 100),
                        PhoneNumber = c.String(nullable: false, maxLength: 20),
                        AccountStatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccountStatus", t => t.AccountStatusId, cascadeDelete: true)
                .Index(t => t.AccountStatusId);
            
            CreateTable(
                "dbo.TrashRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RequestDate = c.DateTimeOffset(nullable: false, precision: 7),
                        FinishedDate = c.DateTimeOffset(nullable: false, precision: 7),
                        Location = c.String(nullable: false, maxLength: 100),
                        ImageLocation = c.String(nullable: false, maxLength: 100),
                        Description = c.String(storeType: "ntext"),
                        TrashTypeId = c.Int(nullable: false),
                        TrashWidthId = c.Int(nullable: false),
                        TrashSizeId = c.Int(nullable: false),
                        CitizenId = c.Int(nullable: false),
                        TrashRequestStatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Citizens", t => t.CitizenId, cascadeDelete: true)
                .ForeignKey("dbo.TrashRequestStatus", t => t.TrashRequestStatusId, cascadeDelete: true)
                .ForeignKey("dbo.TrashSizes", t => t.TrashSizeId, cascadeDelete: true)
                .ForeignKey("dbo.TrashTypes", t => t.TrashTypeId, cascadeDelete: true)
                .ForeignKey("dbo.TrashWidths", t => t.TrashWidthId, cascadeDelete: true)
                .Index(t => t.TrashTypeId)
                .Index(t => t.TrashWidthId)
                .Index(t => t.TrashSizeId)
                .Index(t => t.CitizenId)
                .Index(t => t.TrashRequestStatusId);
            
            CreateTable(
                "dbo.TrashRequestStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TrashSizes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TrashTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TrashWidths",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        Name = c.String(),
                        PhoneNumber = c.String(),
                        EmployeeId = c.String(),
                        RoleId = c.Int(nullable: false),
                        AccountStatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccountStatus", t => t.AccountStatusId, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.AccountStatusId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Employees", "AccountStatusId", "dbo.AccountStatus");
            DropForeignKey("dbo.TrashRequests", "TrashWidthId", "dbo.TrashWidths");
            DropForeignKey("dbo.TrashRequests", "TrashTypeId", "dbo.TrashTypes");
            DropForeignKey("dbo.TrashRequests", "TrashSizeId", "dbo.TrashSizes");
            DropForeignKey("dbo.TrashRequests", "TrashRequestStatusId", "dbo.TrashRequestStatus");
            DropForeignKey("dbo.TrashRequests", "CitizenId", "dbo.Citizens");
            DropForeignKey("dbo.Citizens", "AccountStatusId", "dbo.AccountStatus");
            DropIndex("dbo.Employees", new[] { "AccountStatusId" });
            DropIndex("dbo.Employees", new[] { "RoleId" });
            DropIndex("dbo.TrashRequests", new[] { "TrashRequestStatusId" });
            DropIndex("dbo.TrashRequests", new[] { "CitizenId" });
            DropIndex("dbo.TrashRequests", new[] { "TrashSizeId" });
            DropIndex("dbo.TrashRequests", new[] { "TrashWidthId" });
            DropIndex("dbo.TrashRequests", new[] { "TrashTypeId" });
            DropIndex("dbo.Citizens", new[] { "AccountStatusId" });
            DropTable("dbo.Roles");
            DropTable("dbo.Employees");
            DropTable("dbo.TrashWidths");
            DropTable("dbo.TrashTypes");
            DropTable("dbo.TrashSizes");
            DropTable("dbo.TrashRequestStatus");
            DropTable("dbo.TrashRequests");
            DropTable("dbo.Citizens");
            DropTable("dbo.AccountStatus");
        }
    }
}
