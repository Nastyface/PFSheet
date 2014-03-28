using PFSheet.DAL.DTO;
using PFSheet.DAL.Service;
using System.Collections.Generic;
using System.Linq;

namespace PFSheet.DAL.MSSQL.Services
{
    internal class RaceServiceImpl : BaseService, IRaceService
    {
        public IEnumerable<IRace> GetRaces()
        {
            return Context.Race.ToList() as IEnumerable<IRace>;
        }
    }
}
