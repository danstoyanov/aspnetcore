// <auto-generated />
namespace Microsoft.AspNetCore.Mvc.Testing
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNetCore.Mvc.Testing.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// The provided Type '{0}' does not belong to an assembly with an entry point. A common cause for this error is providing a Type from a class library.
        /// </summary>
        internal static string InvalidAssemblyEntryPoint
        {
            get => GetString("InvalidAssemblyEntryPoint");
        }

        /// <summary>
        /// The provided Type '{0}' does not belong to an assembly with an entry point. A common cause for this error is providing a Type from a class library.
        /// </summary>
        internal static string FormatInvalidAssemblyEntryPoint(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("InvalidAssemblyEntryPoint"), p0);

        /// <summary>
        /// No method 'public static {0} CreateHostBuilder(string[] args)' or 'public static {1} CreateWebHostBuilder(string[] args)' found on '{2}'. Alternatively, {3} can be extended and '{4}' or '{5}' can be overridden to provide your own instance.
        /// </summary>
        internal static string MissingBuilderMethod
        {
            get => GetString("MissingBuilderMethod");
        }

        /// <summary>
        /// No method 'public static {0} CreateHostBuilder(string[] args)' or 'public static {1} CreateWebHostBuilder(string[] args)' found on '{2}'. Alternatively, {3} can be extended and '{4}' or '{5}' can be overridden to provide your own instance.
        /// </summary>
        internal static string FormatMissingBuilderMethod(object p0, object p1, object p2, object p3, object p4, object p5)
            => string.Format(CultureInfo.CurrentCulture, GetString("MissingBuilderMethod"), p0, p1, p2, p3, p4, p5);

        /// <summary>
        /// Can't find'{0}'. This file is required for functional tests to run properly. There should be a copy of the file on your source project bin folder. If that is not the case, make sure that the property PreserveCompilationContext is set to true on your project file. E.g '&lt;PreserveCompilationContext&gt;true&lt;/PreserveCompilationContext&gt;'. For functional tests to work they need to either run from the build output folder or the {1} file from your application's output directory must be copied to the folder where the tests are running on. A common cause for this error is having shadow copying enabled when the tests run.
        /// </summary>
        internal static string MissingDepsFile
        {
            get => GetString("MissingDepsFile");
        }

        /// <summary>
        /// Can't find'{0}'. This file is required for functional tests to run properly. There should be a copy of the file on your source project bin folder. If that is not the case, make sure that the property PreserveCompilationContext is set to true on your project file. E.g '&lt;PreserveCompilationContext&gt;true&lt;/PreserveCompilationContext&gt;'. For functional tests to work they need to either run from the build output folder or the {1} file from your application's output directory must be copied to the folder where the tests are running on. A common cause for this error is having shadow copying enabled when the tests run.
        /// </summary>
        internal static string FormatMissingDepsFile(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("MissingDepsFile"), p0, p1);

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
