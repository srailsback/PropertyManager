namespace PropertyManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddParcels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Parcels",
                c => new
                    {
                        MemberId = c.String(nullable: false, maxLength: 128),
                        ParcelNumber = c.String(),
                        AccountNumber = c.String(),
                        Owner1 = c.String(),
                        Owner2 = c.String(),
                        Address = c.String(),
                        MailingAddress1 = c.String(),
                        MailingAddress2 = c.String(),
                        MailingAddressCity = c.String(),
                        MailingAddressState = c.String(),
                        MailingAddressZip = c.String(),
                        Filing = c.String(),
                        Subdivision = c.String(),
                        Legal = c.String(),
                        GrantLienSignedOn = c.DateTime(),
                        GrantLienFiledOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.MemberId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Parcels");
        }
    }
}
