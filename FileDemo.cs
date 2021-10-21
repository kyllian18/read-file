using System;
using System.IO;

namespace readfile
{
    public class FileDemo
    {
        public static void ReadDemo(string file, string path = "../../TxtFiles")
        {
            string fileToRead = $"{path}/{file}";

            try
            {
                using (StreamReader sr = new StreamReader(fileToRead))
                {
                    //Console.WriteLine($"Reading {fileToRead}");

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

        public static void WriteDemo(string file, string[] content, string path = "../../TxtFiles")
        {
            string fileToWrite = $"{path}/{file}";

            try
            {
                using (StreamWriter sw = new StreamWriter(fileToWrite))
                {
                    //Console.WriteLine($"Writing in {fileToWrite}");

                    foreach (string s in content)
                    {
                        sw.WriteLine(s);
                    }

                    //Console.WriteLine("Done");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could no be written:");
                Console.WriteLine(e.Message);
            }
        }

        public static void ReadAndParseString(string file, string path = "../../TxtFiles")
        {
            string fileToRead = $"{path}/{file}";

            try
            {
                using (StreamReader sr = new StreamReader(fileToRead))
                {
                    //Console.WriteLine($"Reading {fileToRead}");

                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {

                        string[] splitData = line.Split(':');
                        Console.WriteLine($"\t{String.Format("{0,-20}", splitData[0])}\t{splitData[1]}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        public static char[] SplitAString(string stringToSplit)
        {
            char[] characters = stringToSplit.ToCharArray();

            for (int index = 0; index < characters.Length-1; ++index)
            {
                Console.Write($"{characters[index]}, ");
            }
            Console.WriteLine(characters.Length > 0 ? $"{characters[characters.Length - 1]}." : "");

            return characters;
        }

        public static void OutputSeparator()
        {
            Console.WriteLine("".PadRight(Console.WindowWidth / 2, '='));
        }
    }
}