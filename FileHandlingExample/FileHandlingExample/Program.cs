using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader sr = new StreamReader("D:\\Tempfile\\example03.txt"))
            {
                string line = sr.ReadToEnd();
                string singleLine = sr.ReadLine();
                Console.WriteLine(line);
            }
            
            
            //    using (FileStream fs = new FileStream("D:\\Tempfile\\example03.txt", FileMode.Create))
            //    {
            //        StreamWriter sw = new StreamWriter(fs);
            //        sw.WriteLine("Welcome to .NET");
            //        //sw.Flush();
            //    }

            //if (File.Exists("D:\\Tempfile\\example03.txt"))
            //{
            //    using (StreamWriter sw1 = new StreamWriter("D:\\Tempfile\\example03.txt", true))
            //    {
            //        sw1.WriteLine("Welcome to .NET");
            //        //sw.Flush();
            //    }
            //}



            //DriveInfo obj = new DriveInfo("D");
            //Console.WriteLine("Drive Name: " + obj.Name);
            //Console.WriteLine("Drive Type: " + obj.DriveType);
            //Console.WriteLine("Drive Format: " + obj.DriveFormat);
            //Console.WriteLine("Total size: "+ obj.TotalSize);
            //Console.WriteLine("Available Free Space: "+ obj.AvailableFreeSpace);
            //Console.WriteLine("Is Ready: "+ obj.IsReady);

            //DriveInfo[] drives = DriveInfo.GetDrives();

            //foreach (DriveInfo driveInfo in drives)
            //{
            //    Console.WriteLine(driveInfo.Name);
            //}


            //string directoryPath = @"D:\Tempfile\24June\";

            //for (int i = 1 ; i <= 5; i++)
            //{
            //    string folder = directoryPath + i;
            //    Directory.CreateDirectory(folder);

            //}
            //Console.WriteLine("Folders Created");
        }
    }
}
