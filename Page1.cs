
using System;
using System.Data.Entity.Validation;
using System.Globalization;


using System.Data.SQLite;

using Wisej.Web;
using System.Data.Entity;

namespace WjSqlite
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Page1_Load(object sender, EventArgs e)
        {

            //// Set the database initializer:
            ////MyDb.SetInitializeNoCreate();
            //public MyDb() : base()
            //{
            //    Database.SetInitializer<MyDb>(null);
            //}


            using (MyDb Db = new MyDb())
            {
                /*
                    System.IO.FileLoadException: 'Could not load file or assembly 'System.Data.SQLite, Version=1.0.118.0,
                    Culture=neutral' or one of its dependencies. The located assembly's manifest definition does not match the assembly reference.

                // Reverts to 
                    Data Source=(localdb)\mssqllocaldb;AttachDbFilename=|DataDirectory|sqliteDb.mdf;Initial Catalog=sqliteDb;Integrated Security=True;MultipleActiveResultSets=True

                */
                // Perform data access using the context
                Db.Database.Log = Console.Write;

               

                if (Db.Database.Exists())
                {
                    txtDebug.Text += "Database file found\r\n";

                    Db.Database.Delete();
                    txtDebug.Text += "Deleted DB\r\n";
                }

                //System.Data.Entity.Core.ProviderIncompatibleException: 'CreateDatabase is not supported by the provider
                /*
                 * Update-Package –reinstall System.Data.SQLite
                 * 
                    This should compile, but you can't access the database yet. 
                    Sqlite Entity Framework provider does not create the tables, so you'll have to do this yourself.
                        https://learn.microsoft.com/en-us/ef/core/providers/sqlite/limitations

                */
                
               // Db.Database.CreateIfNotExists();  

                // The database will be created if it does not exist.
                var anyData = Db.People; // Replace YourDbSet with an actual DbSet in your context.
                txtDebug.Text += "Created DB\r\n";

                txtConnectionString.Text = Db.Database.Connection.ConnectionString;
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            using (MyDb Db = new MyDb())
            {
               
                People person = new People();
                person.FirstName = "Bob";
                person.LastName = "Smith";
                CultureInfo culture = new CultureInfo("en-AU");
                person.DOB = Convert.ToDateTime("6/12/70", culture);

                Db.People.Add(person);


                // This Exception handler helps to describe what went wrong with the EF database save.
                // It decodes why the data did not comply with defined database field structure. e.g too long or wrong type.
                try
                {
                    Db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
                    Exception raise = dbEx;
                    foreach (DbEntityValidationResult validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (DbValidationError validationError in validationErrors.ValidationErrors)
                        {
                            string message = string.Format("{0}:{1}",
                                validationErrors.Entry.Entity.ToString(),
                                validationError.ErrorMessage);
                            // raise a new exception nesting the current instance as InnerException  
                            raise = new InvalidOperationException(message, raise);
                        }
                    }
                    throw raise;
                }
            }
        }
    }
}