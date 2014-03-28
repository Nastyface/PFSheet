using PFSheet.Utility.Logger;
using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using PostSharp.Patterns.Model;

namespace PFSheet.Utility.PostsharpAspects
{
    [Serializable]
    [LogMethodInOutAttribute(AttributeExclude = true)]
    public sealed class LogMethodInOutAttribute : OnMethodBoundaryAspect
    {
        private static PFLogger Log = new PFLogger();
        private string methodName = "";

        /// <summary> 
        /// Method executed at build time. Initializes the aspect instance. After the execution 
        /// of <see cref="CompileTimeInitialize"/>, the aspect is serialized as a managed  
        /// resource inside the transformed assembly, and deserialized at runtime. 
        /// </summary> 
        /// <param name="method">Method to which the current aspect instance  
        /// has been applied.</param> 
        /// <param name="aspectInfo">Unused.</param> 
        public override void CompileTimeInitialize(MethodBase method, AspectInfo aspectInfo)
        {
            this.methodName = method.DeclaringType.FullName + "." + method.Name;
        }

        public override void RuntimeInitialize(MethodBase method)
        {
            base.RuntimeInitialize(method);
            //Log = Container.Instance.Resolve<IPFLogger>();
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            base.OnEntry(args);
            Log.Debug(String.Format("Enter: {0}", methodName));
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            base.OnExit(args);
            Log.Debug(String.Format("Exit: {0}", methodName));
        }

        public override void OnException(MethodExecutionArgs args)
        {
            base.OnException(args);
            Log.Error(String.Format("Error: {0}", methodName), args.Exception);
            Log.Error(args.Exception);
        }
    }
}