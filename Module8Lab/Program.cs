using System;
using System.Collections.Generic;
using System.Linq;

//Pokemon class
class Pokemon {
    //Attributes for a Pokemon
    public int Id {get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public int Level { get; set; }
}

// Class for creating the list of Pokemon and running the LINQ query
class PokemonLINQLab {
    //Main method - runs automatically when program is run
    static void Main() {
        // Sample data - list of Pokemon
        var pokemons = new List<Pokemon>
        {
            new Pokemon { Id = 1, Name = "Bulbasaur", Type = "Grass", Level = 15},
            new Pokemon { Id = 2, Name = "Charmander", Type = "Fire", Level = 36},
            new Pokemon { Id = 3, Name = "Squirtle", Type = "Water", Level = 10},
            new Pokemon { Id = 4, Name = "Pikachu", Type = "Electric", Level = 22},
            new Pokemon { Id = 5, Name = "Eevee", Type = "Normal", Level = 25},
            new Pokemon { Id = 6, Name = "Starmie", Type = "Water", Level = 20}

        };

        // LINQ Query: find Pokemon ready to evolve (Level 16 for first evolution)
        var readyToEvolve = from p in pokemons
                            where p.Level >= 16
                            orderby p.Level
                            select p;
                
        //Execute the query and display the results
        Console.WriteLine("Pokemon Ready to Evolve: ");
        foreach (var p in readyToEvolve){
            //Print the name, type and level
            Console.WriteLine($"Name: {p.Name}, Type: {p.Type}, Level: {p.Level}");
        }

        // Finds water type pokemon
        var typeWaterPokemon = from p in pokemons       
                           where p.Type == "Water"
                           select p;

        // displays the results
        Console.WriteLine("\nWater type pokemon: ");
        foreach (var p in typeWaterPokemon)
        {
            Console.WriteLine($"Name: {p.Name}, Type: {p.Type}, Level: {p.Level}");
        }
    }
}