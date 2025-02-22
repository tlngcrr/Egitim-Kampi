namespace CSharp301.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()//Eğer ki veritabanına bu değişiklikleri atarsan
                                 //Customer tablonun içerisine CustomerStatus adında bir sütun eklenecek
                                 //Ve bu sütun boolean olacak ve bu sütun boş geçilemez olacak 
        {
            AddColumn("dbo.Customers", "CustomerStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()//Eğer ki işlemi geri almak istersen aşağıdakini yapacak
        {
            DropColumn("dbo.Customers", "CustomerStatus");
        }
    }
}
