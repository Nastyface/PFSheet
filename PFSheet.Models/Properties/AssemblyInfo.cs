﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PFSheet.Utility.PostsharpAspects;
using PostSharp.Extensibility;


// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("PFSheet.BL")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("PFSheet.BL")]
[assembly: AssemblyCopyright("Copyright ©  2014")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("ea0700ac-4987-447d-82a7-ad9d900d6da2")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

[assembly: PFSheet.Utility.PostsharpAspects.LogMethodInOut(AttributeExclude = true, AttributePriority = 0,
            AttributeTargetMemberAttributes = MulticastAttributes.CompilerGenerated)]

[assembly: LogMethodInOut(AttributeTargetTypes = "PFSheet*",
    AttributeTargetTypeAttributes = MulticastAttributes.UserGenerated,
    AttributeTargetMemberAttributes = MulticastAttributes.UserGenerated)]