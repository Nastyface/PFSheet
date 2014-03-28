using Microsoft.Practices.Unity;
using PFSheet.BL.DALProvider;
using PFSheet.BL.Models;
using PFSheet.CommonClasses;
using PFSheet.Utility.Logger;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using PFSheet.Models.Models;

namespace PFSheet.Controllers
{
    public class HomeController : Controller
    {
        private static readonly IPFLogger Log = Container.Instance.Resolve<IPFLogger>();

        public ActionResult Index(string returnUrl)
        {
            //DefaultContext c = new DefaultContext("DefaultConnection");
            //Race r = new Race();
            //r.RaceID = 1;
            //r.Name = "Test";
            //c.Races.Add(r);
            //c.SaveChanges();
            //List<Race> races = c.Races.ToList();

            //Race r = new Race(IDefaultOperations);

            IDALProvider provider = Container.Instance.Resolve<IDALProvider>();
            IList<AbilityScore> d = provider.StaticDataProvider.GetAllAbilityScores();
            //List<Race> races = provider.RaceProvider.GetAllRaces().ToList();


            //IViewRace race = Container.Instance.Resolve<IViewRace>();
            //race.GetAllRaces();
            

            //List<Race> ra = Race.LoadAllRaces(Container.Instance.Resolve<IDefaultOperations>());

            //List<Race> ra = r.LoadAllRaces();

            ViewBag.ReturnUrl = returnUrl;

            return View();
        }
    }
}