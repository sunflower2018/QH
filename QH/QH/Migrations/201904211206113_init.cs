namespace QH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.仓单日报",
                c => new
                    {
                        标识 = c.Int(nullable: false, identity: true),
                        日期 = c.DateTime(nullable: false),
                        商品名称 = c.String(),
                        地区 = c.String(),
                        仓库 = c.String(),
                        注册仓单 = c.Int(nullable: false),
                        变动数量 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.标识);
            
            CreateTable(
                "dbo.成交日报",
                c => new
                    {
                        标识 = c.Int(nullable: false, identity: true),
                        商品名称 = c.String(),
                        交割月份 = c.String(),
                        日期 = c.DateTime(nullable: false),
                        前结算价 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        开盘价 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        最高价 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        最低价 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        收盘价 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        结算价 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        成交手 = c.Int(nullable: false),
                        持仓手 = c.Int(nullable: false),
                        变化手 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.标识);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.成交日报");
            DropTable("dbo.仓单日报");
        }
    }
}
