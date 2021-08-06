using System;
using System.IO;
using JetBrains.Annotations;

namespace CGTK.Utilities.Extensions
{
    //public static class UtilsPATH
    //public static class EnvironmentExtensions
    public static class UtilsPATH
    {
        [PublicAPI]
        public static Boolean ExistsInPATH(in String fileName) => GetFromPATH(fileName).NotNullOrWhiteSpace();

        [PublicAPI]
        public static String GetFromPATH(in String fileName)
        {
            if (File.Exists(fileName)) return Path.GetFullPath(fileName);

            String __values = Environment.GetEnvironmentVariable(variable: "PATH");

            if (__values.IsNullOrWhiteSpace()) return null;

            String[] __paths = __values.Split(Path.PathSeparator);
            foreach (String __path in __paths)
            {
                String __fullPath = Path.Combine(__path, fileName);
                
                if (File.Exists(__fullPath)) return __fullPath;
            }
            
            return null;
        }
    }
}
