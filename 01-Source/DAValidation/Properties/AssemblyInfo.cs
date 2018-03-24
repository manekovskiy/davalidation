using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Web.UI;
using DAValidation;

[assembly: AssemblyTitle("DAValidation")]
[assembly: AssemblyProduct("DAValidation")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]
[assembly: Guid("22566db7-669e-4770-a14c-6b9aed278abe")]

[assembly: AssemblyVersion("1.0.8.0")]
[assembly: AssemblyFileVersion("1.0.8.0")]

[assembly: CLSCompliant(true)]

[assembly: WebResource(DataAnnotationsValidator.DAValidationScriptFileName, "application/x-javascript")]