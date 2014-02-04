using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PFSheet.DAL.RavenDB;
using System.IO;

namespace PFSheet.Tests.RavenDBTests
{
    [TestClass]
    public class DBAccessTest
    {
        [TestMethod]
        public void AccessTest()
        {
            RavenDBTest d = new RavenDBTest();
            d.InitializeDB();
            //Assert.IsTrue(Directory.Exists("~/Database"));

            TestClass tc = new TestClass();
            tc.Id = 11;
            tc.Name = "Oranzada";
            tc.Age = 14;
            tc.DateOfBirth = new DateTime(2013, 11, 13);

            d.WriteToDB(tc);


            TestClass read = d.ReadFromDB(11) as TestClass;
            Assert.IsTrue(read.Name == "Oranzada");
            Assert.IsTrue(read.Age == 14);
            Assert.IsTrue(read.DateOfBirth.Year == 2013);
            Assert.IsTrue(read.DateOfBirth.Month == 11);
            Assert.IsTrue(read.DateOfBirth.Day== 13);


        }
    }

    
}
