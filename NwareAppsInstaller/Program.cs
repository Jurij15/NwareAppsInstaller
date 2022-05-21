using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using NwareAppsInstaller.Core;
using System.IO.Compression;
using System.Diagnostics;

namespace NwareAppsInstaller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NwareAppsInstaller, version 1.0, made by Jurij15 #1867");
            Console.WriteLine("Credit to Picteon for hosting downloads!");
            Console.WriteLine("For more downloads visit https://picteon.dev/files/");
            Console.WriteLine("Initializing...");
            CreateDIr.CreateAllDirs();
            Console.WriteLine("DO NOT CLOSE THIS PROGRAM UNTIL IT IS DONE!");
            Thread.Sleep(450);
            Console.WriteLine("Downloads starting...");
            ///start downloading files
            //download 7zip
            Logger.StartLogger("Downloading 7-Zip...");
            Downloader.StartDownloader(strings.SzipDownload, "C:/Apps/Temp/7-zip.zip");
            Logger.StartLogger("Extracting 7-Zip...");
            ZipFile.ExtractToDirectory("C:/Apps/Temp/7-zip.zip", strings.SzipFinalDir);
            Logger.StartLogger("Downloaded 7-Zip...");
            //download discord
            Logger.StartLogger("Downloading Discord...");
            Downloader.StartDownloader(strings.DiscordDownload, "C:/Apps/Temp/Discord.zip");
            Logger.StartLogger("Extracting Discord...");
            ZipFile.ExtractToDirectory("C:/Apps/Temp/Discord.zip", strings.DiscordFinal);
            Logger.StartLogger("Downloaded Discord...");
            //download chrome
            Logger.StartLogger("Downloading Chrome...");
            Downloader.StartDownloader(strings.ChromeDownload, "C:/Apps/Temp/Chrome.zip");
            Logger.StartLogger("Extracting Chrome...");
            ZipFile.ExtractToDirectory("C:/Apps/Temp/Chrome.zip", strings.ChromeFInal);
            Logger.StartLogger("Downloaded Chrome...");
            //download cmd
            Logger.StartLogger("Downloading CMD...");
            Downloader.StartDownloader(strings.NotCMDNvidiaDownload, strings.CMDFInalExe);
            Logger.StartLogger("Downloaded CMD...");
            //download explorer++
            Logger.StartLogger("Downloading Explorer++...");
            Downloader.StartDownloader(strings.ExplorerPP, strings.ExplorerPPFinalExe);
            Logger.StartLogger("Downloaded Explorer++...");
            //download OBS
            Logger.StartLogger("Downloading OBS...");
            Downloader.StartDownloader(strings.OBSDownload, "C:/Apps/Temp/OBS.zip");
            Logger.StartLogger("Extracting OBS...");
            ZipFile.ExtractToDirectory("C:/Apps/Temp/OBS.zip", strings.OBSDFinal);
            Logger.StartLogger("Downloaded OBS...");
            //WINXSHELL download
            Logger.StartLogger("Downloading WinXShell...");
            Downloader.StartDownloader(strings.WinXShellDownload, strings.WinXShellFInalExe);
            Logger.StartLogger("Downloaded WinXShell...");
            Logger.StartLogger("Downloads Finished!");

            //win x shell 
            Console.WriteLine("Do you want to start WinXShell? [Y][N]");
            string input = Console.ReadLine();
            if (input == "y")
            {
                Console.WriteLine("Starting WinXShell");
                Process p = new Process();
                p.StartInfo.FileName = "C:/Apps/WinXShell/StartWinXShell.exe";
                p.Start();
            }
            else if (input == "n")
            {
                //do nothing
            }

            //start explorer++ to show the apps folder
            Logger.StartLogger("Starting Explorer++");
            Process process = new Process();
            process.StartInfo.FileName = @"C:/Apps/Explorer++/Explorer++.exe";
            process.StartInfo.Arguments = @"C:/Apps/";
            process.Start();

            //When downloads finished
            Console.WriteLine("Everything finished, you can delete temp folder if you want now");
            Console.WriteLine("Exiting...");
            Thread.Sleep(1500);
            Environment.Exit(0);
        }
    }
}