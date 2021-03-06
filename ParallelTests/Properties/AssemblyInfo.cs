﻿using System.Reflection;
using System.Runtime.InteropServices;
using NUnit.Framework;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("ParallelTests")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Evgeniy Kosjakov")]
[assembly: AssemblyProduct("ParallelTests")]
[assembly: AssemblyCopyright("Copyright © Evgeniy Kosjakov 2016 - 2018")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("en")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("300a7c38-39b9-4455-a142-a0ca26352fad")]

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

//Running NUnit tests in parallel:
[assembly: Parallelizable(ParallelScope.Fixtures)]