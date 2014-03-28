using PFSheet.DAL.MSSQL.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFSheet.DAL.MSSQL.Services
{
    internal class BaseService
    {
        protected DefaultContext Context { get; set; }

        protected BaseService()
        {
            Context = new DefaultContext("DefaultConnection");
        }
    }
}
