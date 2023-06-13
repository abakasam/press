using System;
using System.Diagnostics;
using System.IO;
using ICSharpCode.SharpZipLib.GZip;
using ICSharpCode.SharpZipLib.Tar;

namespace WinTar
{
    class Program
    {
        static void Main(string[] args)
        {
            Program driver = new Program();
			
            string command = "";
            string file = "";
            string directory = "";

            if(args.Length == 0) {
                command = "--help";
            }
            if(args.Length == 3) {
                file = args[1];
                directory = args[2];   
            }

            //example: program --compress C:\temp\gzip-test.tgz C:\data
            //example: program --extract C:\temp\gzip-test.tgz ./
			
            if(command == "--compress") driver.compress(file, directory);
            if(command == "--extract") driver.uncompress(file, directory);
            if(command == "--help") {
				Console.WriteLine(" ");
                Console.WriteLine("     wintar [option] <file> <directory>");
                Console.WriteLine("     ");
                Console.WriteLine("     --compress    Create a *.tgz, *.tar, *.tar.gz");
                Console.WriteLine("     --extract     Extract archive");
				Console.WriteLine(" ");
                Console.WriteLine("     wintar --compress C:\\temp\\gzip-test.tgz C:\\data");
				Console.WriteLine(" ");
            }
        }

        public void compress(string tgzFilename, string sourceDirectory) {
            CreateTarGZ(tgzFilename, sourceDirectory);
        }

        //example: CreateTarGZ("c:\temp\gzip-test.tar.gz", "c:\data");
        public void CreateTarGZ(string tgzFilename, string sourceDirectory)
        {
            Stream outStream = File.Create(tgzFilename);
            Stream gzoStream = new GZipOutputStream(outStream);
            TarArchive tarArchive = TarArchive.CreateOutputTarArchive(gzoStream);
			
            tarArchive.RootPath = sourceDirectory.Replace('\\', '/');
            if (tarArchive.RootPath.EndsWith("/"))
                tarArchive.RootPath = tarArchive.RootPath.Remove(tarArchive.RootPath.Length - 1);

            AddDirectoryFilesToTar(tarArchive, sourceDirectory, true);

            tarArchive.Close();
        }

        private void AddDirectoryFilesToTar(TarArchive tarArchive, string sourceDirectory, bool recurse)
        {
            TarEntry tarEntry = TarEntry.CreateEntryFromFile(sourceDirectory);
            tarArchive.WriteEntry(tarEntry, false);

            string[] filenames = Directory.GetFiles(sourceDirectory);
            foreach (string filename in filenames)
            {
                tarEntry = TarEntry.CreateEntryFromFile(filename);
                tarArchive.WriteEntry(tarEntry, true);
            }

            if (recurse)
            {
                string[] directories = Directory.GetDirectories(sourceDirectory);
                foreach (string directory in directories)
                    AddDirectoryFilesToTar(tarArchive, directory, recurse);
            }
        }

        // example: uncompress("C:\\temp\\gzip-test.tgz", "./");
        public void uncompress(string sourceFile, string dstDir) {
            ProcessStartInfo command = new ProcessStartInfo();
            command.CreateNoWindow = false;
            command.UseShellExecute = false;
            command.FileName = "TarTool.exe";
            command.WindowStyle = ProcessWindowStyle.Hidden;
            command.Arguments = sourceFile + " " + dstDir;
            //command.Arguments = "C:\\temp\\gzip-test.tgz ./";

            Process run = Process.Start(command);
            run.WaitForExit();
        }
    }
}