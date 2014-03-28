using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFSheet.Tests
{
    internal class IOWorker
    {
        public static void ClearFilesFromFolder(string folderPath)
        {
            foreach (string file in Directory.GetFiles(folderPath))
            {
                File.Delete(file);
            }
        }

        public static void DeleteFolder(string folderPath)
        {
            Directory.Delete(folderPath);
        }
    }
}
