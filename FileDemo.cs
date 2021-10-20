using System;
using System.IO;

namespace readfile
{
    public class FileDemo
    {
        public static void ReadDemo(string file, string path = "../..")
        {
            string fileToRead = $"{path}/{file}";

            try
            {
                using (StreamReader sr = new StreamReader(fileToRead))
                {
                    Console.WriteLine($"Reading {fileToRead}");

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

        public static void WriteDemo(string file, string[] content, string path = "../..")
        {
            string fileToWrite = $"{path}/{file}";

            try
            {
                using (StreamWriter sw = new StreamWriter(fileToWrite))
                {
                    Console.WriteLine($"Writing in {fileToWrite}");

                    foreach (string s in content)
                    {
                        sw.WriteLine(s);
                    }

                    Console.WriteLine("Done");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could no be written:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
