using System;
using System.Data.Entity; // For DbContext and related types
using System.Data.SQLite; // For SQLite data access
using System.Data.SQLite.EF6;

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
            DbConfiguration.SetConfiguration(new CustomDbConfiguration());

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
    public class CustomDbConfiguration : DbConfiguration
    {
        public CustomDbConfiguration()
        {


            SetProviderFactory("System.Data.SQLite", SQLiteFactory.Instance);

            //SetProviderServices("System.Data.SQLite", SQLiteProviderServices.Instance);
            SetProviderServices("System.Data.SQLite", (System.Data.Entity.Core.Common.DbProviderServices)SQLiteProviderFactory.Instance.GetService(typeof(System.Data.Entity.Core.Common.DbProviderServices)));
        }
    }


}