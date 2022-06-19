using System;
using System.IO;

namespace DisplayFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayFile();
        }

        public static void DisplayFile()
        {
            string directoryPath = "/Users/aleks/Projects/WorkingWithFiles/myData";
            string[] allFiles = Directory.GetFiles(directoryPath, "*.*");

            foreach (string file in allFiles)
            {
                string fileName = new FileInfo(file).Name;
                string fileCreationDate = new FileInfo(file).CreationTime.ToString();
                Console.WriteLine($"{fileName} + {fileCreationDate}");
            }
        }
    }
}
