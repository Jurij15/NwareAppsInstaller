using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NwareAppsInstaller.Core
{
    public static class CreateDIr
    {
        public static void CreateAllDirs()
        {
            if (!Directory.Exists(@"C:/Apps"))
            {
                Directory.CreateDirectory("C:/Apps");
            }
            CreateDIr.CreateTempDir();
        }

        public static void CreateTempDir()
        {
            if (!Directory.Exists(@"C:/Apps/Temp"))
            {
                Directory.CreateDirectory("C:/Apps/Temp");
            }
        }
    }
}
