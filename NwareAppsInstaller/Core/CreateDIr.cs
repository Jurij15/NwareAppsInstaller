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
            CreateDIr.CreateAPPDirs();
        }

        public static void CreateTempDir()
        {
            if (!Directory.Exists(@"C:/Apps/Temp"))
            {
                Directory.CreateDirectory("C:/Apps/Temp");
            }
        }

        public static void CreateAPPDirs()
        {
            if (!Directory.Exists(strings.WinXShellFinal))
            {
                Directory.CreateDirectory(strings.WinXShellFinal);
            }
            if (!Directory.Exists(strings.ExplorerPPFinal))
            {
                Directory.CreateDirectory(strings.ExplorerPPFinal);
            }
            if (!Directory.Exists(strings.OBSDFinal))
            {
                Directory.CreateDirectory(strings.OBSDFinal);
            }
            if (!Directory.Exists(strings.ChromeFInal))
            {
                Directory.CreateDirectory(strings.ChromeFInal);
            }
            if (!Directory.Exists(strings.DiscordFinal))
            {
                Directory.CreateDirectory(strings.DiscordFinal);
            }
            if (!Directory.Exists(strings.SzipFinalDir))
            {
                Directory.CreateDirectory(strings.SzipFinalDir);
            }
        }
    }
}
