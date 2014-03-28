using PFSheet.DAL.Service;

namespace PFSheet.BL.DALProvider.Providers
{
    internal class ClassProvider : DALBaseProvider, IClassProvider
    {
        public ClassProvider(IDALService dalService) : base (dalService)
        {
            
        }
    }
}