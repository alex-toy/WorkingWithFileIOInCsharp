using System;
using System.IO;


namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FileInfos();

            //CheckDirectoryExists();

            //CopyFiles();

            MoveFiles();

            Console.ReadLine();
        }

        private static void MoveFiles()
        {
            string rootPath = @"C:\source\CSsharpPackages\WorkingWithFileIOInCsharp\FileSystem";
            string destinationFolder = @"C:\source\CSsharpPackages\WorkingWithFileIOInCsharp\FileSystem\UnexistingFolder\";
            string[] files = Directory.GetFiles(rootPath);
            Directory.CreateDirectory(destinationFolder);
            foreach (string file in files) File.Move(file, $"{destinationFolder}{Path.GetFileName(file)}", true);
        }

        private static void CopyFiles()
        {
            string rootPath = @"C:\source\CSsharpPackages\WorkingWithFileIOInCsharp\FileSystem";
            string destinationFolder = @"C:\source\CSsharpPackages\WorkingWithFileIOInCsharp\FileSystem\UnexistingFolder\";
            string[] files = Directory.GetFiles(rootPath);
            Directory.CreateDirectory(destinationFolder);
            foreach (string file in files) File.Copy(file, $"{destinationFolder}{Path.GetFileName(file)}", true);

            for (int i = 0; i < files.Length; i++)
            {
                File.Copy(files[i], $"{destinationFolder}{i}.txt");
            }
        }

        private static void CheckDirectoryExists()
        {
            string rootPath = @"C:\source\CSsharpPackages\WorkingWithFileIOInCsharp\FileSystem\unexistingFolder";
            bool exists = Directory.Exists(rootPath);
            if (!exists) Console.WriteLine("Directory doesn't exist");
        }

        private static void FileInfos()
        {
            string rootPath = @"C:\source\CSsharpPackages\WorkingWithFileIOInCsharp\FileSystem";

            //string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
            //foreach (string dir in dirs) Console.WriteLine(dir);

            //string[] files = Directory.GetFiles(rootPath, "*", SearchOption.TopDirectoryOnly);
            string[] files = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);
            //foreach (string file in files) Console.WriteLine(file);
            //foreach (string file in files) Console.WriteLine(Path.GetFileName(file));
            //foreach (string file in files) Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            //foreach (string file in files) Console.WriteLine(Path.GetFullPath(file));
            //foreach (string file in files) Console.WriteLine(Path.GetDirectoryName(file));
            foreach (string file in files)
            {
                var fileInfo = new FileInfo(file);
                Console.WriteLine($"{Path.GetFileName(file)} : {fileInfo.Length} bytes");
            }
        }
    }
}
