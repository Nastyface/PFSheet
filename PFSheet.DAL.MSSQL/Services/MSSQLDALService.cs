using PFSheet.DAL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFSheet.DAL.MSSQL.Services
{
    public class MSSQLDALService : IDALService
    {
        private IClassService _classService;
        public IClassService ClassService
        {
            get { return _classService ?? (_classService = new ClassServiceImpl()); }
        }

        private IRaceService _raceService;
        public IRaceService RaceService
        {
            get { return _raceService ?? (_raceService = new RaceServiceImpl()); }
        }

        private IStaticDataService _staticDataService;
        public IStaticDataService StaticDataService
        {
            get { return _staticDataService ?? (_staticDataService = new StaticDataServiceImpl()); }
        }
    }
}
