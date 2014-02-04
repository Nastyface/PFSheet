using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common.Logging;
using PFSheet.Utility.Logger;

namespace PFSheet.Tests
{
    [TestClass]
    public class LoggerTest
    {
        [TestMethod]
        public void TestNLog()
        {
            PFLogger logger = new PFLogger();
            logger.Debug("testing the logger");
            logger.Debug("testing the logger2");

            logger = new PFLogger();
            logger.Debug("testing the logger3");
        }
    }
}
