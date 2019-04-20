namespace QH
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class QHDBModel : DbContext
    {
        // Your context has been configured to use a 'QHDBModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'QH.QHDBModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'QHDBModel' 
        // connection string in the application configuration file.
        public QHDBModel()
            : base("name=QHDBModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<仓单日报> 仓单日报s { get; set; }
        public virtual DbSet<成交日报> 成交日报s { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}