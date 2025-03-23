using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PokemonTrainer
{
    internal class Trainers
    {
        public Trainers(string name) 
        {
            Name = name;
            NumberOfBadges = 0;
            pokemons = new List<Pokemon>();
        }
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> pokemons { get; set; }
    }
}
