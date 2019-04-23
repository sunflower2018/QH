namespace QH.Migrations
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<QH.qhDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(QH.qhDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.成交日报s.AddOrUpdate(new 成交日报 { 标识 = 1, 交割月份="1905", 前结算价=3821, 变化手=30, 商品名称="铜", 开盘价=3851, 成交手=1000, 持仓手=2560, 收盘价=3900, 日期=new DateTime(2019,4,20) });
            context.成交日报s.AddOrUpdate(new 成交日报 { 标识 = 2, 交割月份 = "1905", 前结算价 = 3823, 变化手 = 30, 商品名称 = "铜", 开盘价 = 3851, 成交手 = 1000, 持仓手 = 2560, 收盘价 = 3900, 日期 = new DateTime(2019, 4, 20) });
        }
    }
}
