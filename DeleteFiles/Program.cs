using System;
using System.IO;

namespace DeleteFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of file you want to delete: ");
            string fileName = Console.ReadLine();

            DeleteFile(fileName);
        }

        public static void DeleteFile(string userFile)
        {
            string sourcePath = "/Users/aleks/Projects/WorkingWithFiles/Data/";

            string filePath = sourcePath + userFile + ".txt";

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine($"File {userFile}.txt was deleted.");
            }
            else
            {
                Console.WriteLine($" File {userFile}.txt wasn't found.");
            }
        }
    }
}
