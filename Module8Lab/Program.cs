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
    public int Attack { get; set; } // attack stat for pokemons
}

// Class for creating the list of Pokemon and running the LINQ query
class PokemonLINQLab {
    //Main method - runs automatically when program is run
    static void Main() {
        // Sample data - list of Pokemon
        var pokemons = new List<Pokemon>
        {
            new Pokemon { Id = 1, Name = "Bulbasaur", Type = "Grass", Level = 15, Attack = 49},
            new Pokemon { Id = 2, Name = "Charmander", Type = "Fire", Level = 36, Attack = 52},
            new Pokemon { Id = 3, Name = "Squirtle", Type = "Water", Level = 10, Attack = 48},
            new Pokemon { Id = 4, Name = "Pikachu", Type = "Electric", Level = 22, Attack = 55},
            new Pokemon { Id = 5, Name = "Eevee", Type = "Normal", Level = 25, Attack = 55},
            new Pokemon { Id = 6, Name = "Starmie", Type = "Water", Level = 6, Attack = 41},
            new Pokemon { Id = 7, Name = "Mewtwo", Type = "Psychic", Level = 70, Attack =110 },
            new Pokemon { Id = 8, Name = "Gengar", Type = "Ghost/Poison", Level = 20, Attack = 46} 

        };

        // LINQ Query: find Pokemon ready to evolve (Level 16 for first evolution)
        var readyToEvolve = from p in pokemons
                            where p.Level >= 16
                            orderby p.Level
                            select p;
                
        //Execute the query and display the results
        Console.WriteLine("\nPokemon Ready to Evolve: ");
        foreach (var p in readyToEvolve){
            //Print the name, type and level
            Console.WriteLine($"Name: {p.Name}, Type: {p.Type}, Level: {p.Level}");
        }

        // Query 1: keep only the Pokemon with a high Attack
        var strongPokemon = (from p in pokemons
                     where p.Attack >= 50
                     select p).ToList();
        
        // Query 2: sort the strong Pokemon by name
        var sortedPokemon = (from p in strongPokemon
                     orderby p.Name
                     select p).ToList();

        // Display the strong Pokemon in alphabetical order
        Console.WriteLine("\nStrong Pokemon (Attack 50 or higher):");

        foreach (var p in sortedPokemon)
        {
            Console.WriteLine($"Name: {p.Name}, Type: {p.Type}, Attack: {p.Attack}");
        }

        // Query 3: find the Water type Pokemon, highest Level first
        var waterPokemon = (from p in pokemons
                        where p.Type == "Water"
                        orderby p.Level descending
                        select p).ToList();

        // Display the Water type Pokemon
        Console.WriteLine("\nWater Pokemon (Highest Level First):");

        foreach (var p in waterPokemon)
        {
            Console.WriteLine($"Name: {p.Name}, Type: {p.Type}, Level: {p.Level}");
        }             
    }
}