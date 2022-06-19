using System;
using System.IO;

namespace MoveFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the file name you want to move: ");
            string fileName = Console.ReadLine();

            MoveFile(fileName);

        }

        public static void MoveFile(string userFile)
        {
            string sourceDirectory = "/Users/aleks/Projects/WorkingWithFiles/Data/";
            string destinationDirectory = "/Users/aleks/Projects/WorkingWithFiles/myData/";

            string filePath = sourceDirectory + userFile + ".txt";

            if (File.Exists(filePath))
            {
                File.Move(filePath, destinationDirectory + userFile + ".txt");
                Console.WriteLine($"File {userFile}.txt was succesfully moved.");
            }
            else
            {
                Console.WriteLine($"File {userFile}.txt wasn't found.");
            }

        }


    }
}
