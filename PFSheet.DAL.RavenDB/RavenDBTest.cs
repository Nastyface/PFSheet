using Raven.Client;
using Raven.Client.Embedded;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFSheet.DAL.RavenDB
{
    public class RavenDBTest
    {
        private EmbeddableDocumentStore store = null;
        public void InitializeDB()
        {
            store = new EmbeddableDocumentStore { ConnectionStringName = "Local" };
            store.Initialize();            
        }

        public void WriteToDB(TestClass testobj)
        {
            // Saving changes using the session API
            using (IDocumentSession session = store.OpenSession())
            {
                // Operations against session
                session.Store(testobj);
                // Flush those changes
                session.SaveChanges();
            }
        }

        public object ReadFromDB(int id)
        {
            TestClass obj = null;
            // Saving changes using the session API
            using (IDocumentSession session = store.OpenSession())
            {
                // Operations against session
                obj = session.Load<TestClass>(id);
            }

            return obj;
        }
    }

    public class TestClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
