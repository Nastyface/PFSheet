using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PFSheet.CommonClasses
{
    public static class Container
    {
        private static IUnityContainer _container;

        public static IUnityContainer Instance
        {
            get { return _container ?? (_container = new UnityContainer()); }
        }
    }
}