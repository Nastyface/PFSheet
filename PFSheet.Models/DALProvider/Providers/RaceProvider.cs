using PFSheet.BL.Models;
using PFSheet.DAL.DTO;
using PFSheet.DAL.Service;
using System.Collections.Generic;

namespace PFSheet.BL.DALProvider.Providers
{
    internal class RaceProvider : DALBaseProvider, IRaceProvider
    {
        public RaceProvider(IDALService dalService) : base(dalService)
        {
            
        }

        public IEnumerable<Race> GetAllRaces()
        {
            IEnumerable<IRace> races = _dalService.RaceService.GetRaces();

            List<Race> retVal = new List<Race>();

            if (races != null)
            {
                foreach (IRace race in races)
                {
                    retVal.Add(new Race(race));
                }
            }

            return retVal as IEnumerable<Race>;
        }
    }
}
