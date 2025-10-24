using System;
using System.IO;
namespace Bai02
{
    

    class Program
    {
        static void Main()
        {
            Console.Write("Nhap duong dan: ");
            string path = Console.ReadLine();

            if (!Directory.Exists(path))
            {
                Console.WriteLine("Duong dan khong ton tai.");
                return;
            }

            Console.WriteLine($"\nDirectory of {path}\n");

            string[] dirs = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);

            long totalBytes = 0;           
            foreach (string dir in dirs)
            {
                DirectoryInfo d = new DirectoryInfo(dir);
                Console.WriteLine($"{d.LastWriteTime:dd/MM/yyyy hh:mm tt}    <DIR>          {d.Name}");
            }
                        
            foreach (string file in files)
            {
                FileInfo f = new FileInfo(file);
                Console.WriteLine($"{f.LastWriteTime:dd/MM/yyyy hh:mm tt}    {f.Length,15:N0}    {f.Name}");
                totalBytes += f.Length;
            }

            Console.WriteLine($"\n{files.Length} File(s)\t{totalBytes:N0} bytes");

            Console.Write($"{dirs.Length} Dir(s)\t");
            DriveInfo drive = new DriveInfo(Path.GetPathRoot(path));
            Console.WriteLine($"{drive.AvailableFreeSpace:N0} bytes free");

        }
    }

}
