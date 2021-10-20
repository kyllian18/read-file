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
            Console.WriteLine();

            // SECOND PART: Write in a file
            string heroesFile = "heroes.txt";
            string[] heroes = { "Batman", "Superman", "The Hulk" };

            FileDemo.WriteDemo(heroesFile, heroes);
            FileDemo.ReadDemo(heroesFile);
            Console.WriteLine();

            // THIRD PART: Separate in different files
            string dc_heroesFile = "heroes-dc.txt";
            string[] dc_heroes = { "Batman", "Superman", "Aquaman" };
            FileDemo.WriteDemo(dc_heroesFile, dc_heroes);
            FileDemo.ReadDemo(dc_heroesFile);
            Console.WriteLine();

            string marvel_heroesFile = "heroes-marvel.txt";
            string[] marvel_heroes = { "Spiderman", "The Hulk", "Thanos" };
            FileDemo.WriteDemo(marvel_heroesFile, marvel_heroes);
            FileDemo.ReadDemo(marvel_heroesFile);
            Console.WriteLine();
        }
    }
}
