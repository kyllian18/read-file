using System;
using System.IO;

namespace readfile
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = "..";
            string file = "tux.txt";
            string fileToRead = $"{path}/{file}";

            try
            {
                using (StreamReader sr = new StreamReader(fileToRead))
                {
                    Console.Write($"Reading {fileToRead}");

                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine($"\t{line}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
