using System;
using System.IO;

namespace CreateFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine();

            CreateFile(fileName);
        }


        public static void CreateFile(string userFile)
        {
            string fileRoot = "/Users/aleks/Projects/WorkingWithFiles/Data/";

            string filePath = fileRoot + userFile + ".txt";

            if (File.Exists(filePath))
            {
                Console.WriteLine($"File {userFile}.txt already exists");
            }
            else
            {
                File.Create(filePath);
                Console.WriteLine($"File {userFile}.txt was created in {fileRoot}.");
            }
        }
    }
}
