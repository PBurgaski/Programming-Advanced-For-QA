namespace _04.PokemonTrainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            string input = Console.ReadLine();
            List<Trainers> trainers = new List<Trainers>();
            // Logic
            while (input != "Tournament")
            {
                string[] info = input.Split(' ');
                string trainerName = info[0];
                string pokemonName = info[1];
                string pokemonElement = info[2];
                int pokemonHealth = int.Parse(info[3]);
                if (trainers.Any(n => n.Name == trainerName))
                {
                    Trainers existingTrainer = trainers.First(n => n.Name == trainerName);
                    Pokemon newPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                    existingTrainer.pokemons.Add(newPokemon);
                }
                else
                {
                    Trainers newTrainer = new Trainers(trainerName);
                    Pokemon newPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                    newTrainer.pokemons.Add(newPokemon);
                    trainers.Add(newTrainer);
                }
                input = Console.ReadLine();
            }
            string element = Console.ReadLine();
            while (element != "End")
            {
                foreach (var currentTrainer in trainers)
                {
                    if (currentTrainer.pokemons.Any(p => p.Element == element))
                    {
                        currentTrainer.NumberOfBadges++;
                    }
                    else
                    {
                        foreach (var pokemon in currentTrainer.pokemons)
                        {
                            pokemon.Health -= 10;
                        }
                currentTrainer.pokemons.RemoveAll(p => p.Health <= 0);
                    }
                }
                element = Console.ReadLine();
            }
            // Output
            foreach (var trainer in trainers.OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.pokemons.Count}");
            }
        }
    }
}

