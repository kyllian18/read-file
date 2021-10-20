using System;

namespace readfile
{
    class Program
    {
        public static void Main(string[] args)
        {
            // FIRST PART: Read a file
            string tuxFile = "tux.txt";

            FileDemo.ReadDemo(tuxFile);
            FileDemo.OutputSeparator();

            // SECOND PART: Write in a file
            string heroesFile = "heroes.txt";
            string[] heroes = { "Batman", "Superman", "The Hulk" };

            FileDemo.WriteDemo(heroesFile, heroes);
            FileDemo.ReadDemo(heroesFile);
            FileDemo.OutputSeparator();

            // THIRD PART: Parse a file
            string dc_heroesFile = "heroes-dc.txt";
            string[] dc_heroes = { "Batman:Bruce Wayne", "Superman:Clark Kent", "Aquaman:Arthur Curry" };
            FileDemo.WriteDemo(dc_heroesFile, dc_heroes);
            FileDemo.ReadAndParseString(dc_heroesFile);
            FileDemo.OutputSeparator();

            string marvel_heroesFile = "heroes-marvel.txt";
            string[] marvel_heroes = { "Spiderman:Peter Parker", "The Hulk:David Banner", "Captain America:Steve Rogers" };
            FileDemo.WriteDemo(marvel_heroesFile, marvel_heroes);
            FileDemo.ReadAndParseString(marvel_heroesFile);
            FileDemo.OutputSeparator();

            // FOURTH PART: Split a string
            char[] characters = FileDemo.SplitAString("Supercalifragilisticexpialidocious");
            Console.WriteLine($"The character at index 10 (position 11) is '{characters[10]}'.");
        }
    }
}