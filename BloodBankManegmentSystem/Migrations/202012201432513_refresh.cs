﻿namespace BloodBankManegmentSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class refresh : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BloodTypes", "bloodGroup", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BloodTypes", "bloodGroup", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Donors", "gender", c => c.String());
        }
    }
}
