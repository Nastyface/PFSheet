using System.Data.Entity;
using Devtalk.EF.CodeFirst;
using PFSheet.DAL.MSSQL.Contexts;

[assembly: WebActivator.PreApplicationStartMethod(typeof(PFSheet.DAL.MSSQL.App_Start.RecreateDatabase), "Start")]

namespace PFSheet.DAL.MSSQL.App_Start {
    public static class RecreateDatabase
    {
        public static void Start() {
            // Uncomment this line and replace CONTEXT_NAME with the name of your DbContext if you are 
            // using your DbContext to create and manage your database
             //Database.SetInitializer(new DontDropDbJustCreateTablesIfModelChanged<DefaultContext>());
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DefaultContext>());
            Database.SetInitializer(new DefaultContextInitializer());
            
            //Database.SetInitializer<DefaultContext>(new DropCreateDatabaseAlways<DefaultContext>());
             //System.Data.Entity.DropCreateDatabaseAlways
        }
    }
}
