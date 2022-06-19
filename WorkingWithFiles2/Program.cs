using System;
using System.IO;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want to do with file?");
            Console.WriteLine("Create a new one, delete or move existing.");
            Console.WriteLine("To choose operation choose: C, M, or D");
            Console.WriteLine("C - create, M - move, D - delete,");
            char operation = Convert.ToChar(Console.ReadLine().ToLower().ToUpper());

            if (operation == 'C')
            {
                CreateFile();
            }
            else if (operation == 'M')
            {
                MoveFile();
            }
            else if (operation == 'D')
            {
                DeleteFile();
            }

        }

        private static void CreateFile()
        {
            Console.WriteLine("Enter a file name:");
            string fileName = Console.ReadLine().ToUpper().ToLower();

            string fileRoot = "/Users/aleks/Projects/WorkingWithFiles/Data/";
            string filePath = fileRoot + fileName + ".txt";

            if (File.Exists(filePath))
            {
                Console.WriteLine($"File {fileName}.txt already exists in {fileRoot}.");
            }
            else
            {
                File.Create(filePath);
                Console.WriteLine($"File {fileName}.txt was created in {fileRoot}.");
            }

        }

        private static void MoveFile()
        {
            Console.WriteLine("Enter file name you want to move ");
            string fileName = Console.ReadLine().ToUpper().ToLower();

            string sourceDirectory = "/Users/aleks/Projects/WorkingWithFiles/Data/";
            string destinationDirectory = "/Users/aleks/Projects/WorkingWithFiles/myData/";

            string filePath = sourceDirectory + fileName + ".txt";

            if (File.Exists(filePath))
            {
                File.Move(filePath, destinationDirectory + fileName + ".txt");
                Console.WriteLine($"File {fileName} was moved.");
            }
            else
            {
                Console.WriteLine($"File {fileName} wasn't found.");
            }
        }

        private static void DeleteFile()
        {

            Console.WriteLine("Enter file to delete:");
            string fileName = Console.ReadLine().ToUpper().ToLower();

            string fileRooth = "/Users/aleks/Projects/WorkingWithFiles/Data/";
            string filePath = fileRooth + fileName + ".txt";

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine($"File {fileName}.txt was deleted.");
            }
            else
            {
                Console.WriteLine($"{fileName}.txt wasn't found.");
            }

        }
    }
}
