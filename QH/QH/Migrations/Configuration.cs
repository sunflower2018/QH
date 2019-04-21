namespace QH.Migrations
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<QH.QHDBModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(QH.QHDBModel context)
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

            context.�ɽ��ձ�s.AddOrUpdate(new �ɽ��ձ� { ��ʶ = 1, �����·�="1905", ǰ�����=3821, �仯��=30, ��Ʒ����="ͭ", ���̼�=3851, �ɽ���=1000, �ֲ���=2560, ���̼�=3900, ����=new DateTime(2019,4,20) });
            context.�ɽ��ձ�s.AddOrUpdate(new �ɽ��ձ� { ��ʶ = 2, �����·� = "1905", ǰ����� = 3823, �仯�� = 30, ��Ʒ���� = "ͭ", ���̼� = 3851, �ɽ��� = 1000, �ֲ��� = 2560, ���̼� = 3900, ���� = new DateTime(2019, 4, 20) });
        }
    }
}