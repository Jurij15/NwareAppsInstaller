using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace NwareAppsInstaller.Core
{
    public class EnableWinXShell
    {
        public void WinXShell()
        {
            Console.WriteLine("Do you want to start WinXShell? [Y][N]");
            string input = Console.ReadLine();
            if (input == "y")
            {
                Console.WriteLine("Starting WinXShell");
                Process p = new Process();
                p.StartInfo.FileName = strings.WinXShellFInalExe;
                p.Start();
            }
            else if (input == "n")
            {
                //do nothing
            }
        }
    }
}
