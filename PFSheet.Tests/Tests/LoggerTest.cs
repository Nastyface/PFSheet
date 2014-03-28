using System;
using Common.Logging;
using PFSheet.Utility.Logger;
using NUnit.Framework;
using System.IO;


namespace PFSheet.Tests.Tests
{
    [TestFixture]
    public class LoggerTest
    {
        private string _loggerFolderPath = "logs/";
        private string _loggerFileName;
        private PFLogger _logger;

        [SetUp]
        public void LoggerSetup()
        {
            _loggerFileName = String.Format("NLOG-{0}.log", DateTime.Now.ToString("yyyy-MM-dd"));
            IOWorker.ClearFilesFromFolder(_loggerFolderPath);
            IOWorker.DeleteFolder(_loggerFolderPath);            
        }

        [Test]
        public void TestNLog()
        {
            if (Directory.Exists(_loggerFolderPath))
            {
                throw new Exception("Logger folder already exists. Setup failed.");
            }

            string logFilePath = String.Format("{0}{1}", _loggerFolderPath, _loggerFileName);
            string line1 = "Testing line 1 in the logger";
            string line2 = "This is second line of the test";

            _logger = new PFLogger();
            _logger.Debug(line1);
            _logger.Debug(line2);

            //checking if folder where logs are stored is created
            Assert.IsTrue(Directory.Exists(_loggerFolderPath));

            //asserting that log file exists
            Assert.IsTrue(File.Exists(logFilePath));
            
            //reading log file content and checking if it contains test text
            string[] logLines = File.ReadAllLines(logFilePath);
            Assert.IsNotNull(logLines);
            Assert.AreEqual(logLines.Length, 2);
            Assert.IsTrue(logLines[0].Contains(line1));
            Assert.IsTrue(logLines[1].Contains(line2));

            //reinstanciating logger and checking if it appends to the existing file
            string line3 = "Third line test of the logger";
            string line4 = "And forth and final line";

            _logger = new PFLogger();
            _logger.Debug(line3);
            _logger.Debug(line4);

            logLines = File.ReadAllLines(logFilePath);
            Assert.IsNotNull(logLines);
            Assert.AreEqual(logLines.Length, 4);
            Assert.IsTrue(logLines[0].Contains(line1));
            Assert.IsTrue(logLines[1].Contains(line2));
            Assert.IsTrue(logLines[2].Contains(line3));
            Assert.IsTrue(logLines[3].Contains(line4));
        }
    }
}
