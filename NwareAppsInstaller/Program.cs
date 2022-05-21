using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using NwareAppsInstaller.Core;
using System.IO.Compression;

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
            Thread.Sleep(450);
            Console.WriteLine("Downloads starting...");
            ///start downloading files
            //download 7zip
            Logger.StartLogger("Downloading 7-Zip");
            Downloader.StartDownloader(strings.SzipDownload, "C:/Apps/Temp/7-zip.zip");
            ZipFile.ExtractToDirectory("C:/Apps/Temp/7-zip.zip", )
        }
    }
}