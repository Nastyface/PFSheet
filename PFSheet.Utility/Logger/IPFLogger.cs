using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFSheet.Utility.Logger
{
    public interface IPFLogger
    {
        void Debug(string message);
        void Info(string message);
        void Warning(string message);
        void Error(string message);
        void Error(Exception ex);
        void Error(string message, Exception ex);
    }
}
