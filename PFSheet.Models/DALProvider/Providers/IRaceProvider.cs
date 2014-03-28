using PFSheet.BL.Models;
using System.Collections.Generic;

namespace PFSheet.BL.DALProvider.Providers
{
    public interface IRaceProvider
    {
        IEnumerable<Race> GetAllRaces();
    }
}
