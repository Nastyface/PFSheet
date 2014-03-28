using Microsoft.Practices.Unity;
using PFSheet.BL.DALProvider;
using PFSheet.CommonClasses;
using PFSheet.DAL.DTO;
using PFSheet.DAL.MSSQL;
using PFSheet.DAL.MSSQL.Contexts;
using PFSheet.DAL.MSSQL.Services;
using PFSheet.DAL.Service;
using PFSheet.Utility.Logger;
using System.Data.Entity;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace PFSheet
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {        
        protected void Application_Start()
        {
            BuildObjectGraph(Container.Instance);
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();

            

        }

        private void BuildObjectGraph(Microsoft.Practices.Unity.IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<IPFLogger, PFLogger>();
            //unityContainer.RegisterType<IRaceService, RaceServiceImpl>();
            //RaceProvider.RaceService = unityContainer.Resolve<IRaceService>();
            unityContainer.RegisterType<IDALService, MSSQLDALService>();
            unityContainer.RegisterType<IDALProvider, DALProvider>();
            
            unityContainer.RegisterType<IAbilityScore, AbilityScore>();
        }
    }
}