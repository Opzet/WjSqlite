using System;
using System.Data.Common;
using System.Data.Entity; // For DbContext and related types
using System.Data.Entity.Core.Common;
using System.Data.Entity.Infrastructure;
using System.Data.SQLite; // For SQLite data access
using System.Data.SQLite.EF6;
using SQLite.CodeFirst;
using Wisej.Web;

namespace WjSqlite
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {

            // Set the custom DbConfiguration before using Entity Framework.
            DbConfiguration.SetConfiguration(new MyConfiguration());

            Application.MainPage = new Page1();
        }

        //
        // You can use the entry method below
        // to receive the parameters from the URL in the args collection.
        //
        //static void Main(NameValueCollection args)
        //{
        //}

    }

    //[DbConfigurationType(typeof(MyConfiguration))]
    //public class Context : DbContext
    //{

    public class MyConfiguration : DbConfiguration, IDbConnectionFactory
    {
        public MyConfiguration()
        {
            SetProviderFactory("System.Data.SQLite", SQLiteFactory.Instance);
            SetProviderFactory("System.Data.SQLite.EF6", SQLiteProviderFactory.Instance);

            var providerServices = (DbProviderServices)SQLiteProviderFactory.Instance.GetService(typeof(DbProviderServices));

            SetProviderServices("System.Data.SQLite", providerServices);
            SetProviderServices("System.Data.SQLite.EF6", providerServices);

            SetDefaultConnectionFactory(this);
        }

        public DbConnection CreateConnection(string connectionString)
            => new SQLiteConnection(connectionString);
    }
}