using System.Collections.Generic;

namespace _01.Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            int n = int.Parse(Console.ReadLine());
            string[] input = Array.Empty<string>();
            List<Songs> songs = new List<Songs>();
            string typeList;
            string name;
            string time;

            // Logic
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine()
                               .Split('_')
                               .ToArray();
                typeList = input[0];
                name = input[1];
                time = input[2];
                Songs currentSong = new Songs(typeList, name, time);
                songs.Add(currentSong);
            }
            string playOut = Console.ReadLine();
            // Output
            if (playOut == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs.Where(s => s.TypeList == playOut))
                {
                    Console.WriteLine(song.Name);
                }
            }
            
        }
    }
    public class Songs
    {
        public Songs(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
