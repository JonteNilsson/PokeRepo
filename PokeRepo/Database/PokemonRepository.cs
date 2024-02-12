using PokeRepo.Models;
using PokeRepo.Services;

namespace PokeRepo.Database
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly AppDbContext context;

        public PokemonRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Root> AddPokemon(Root pokemon)
        {

            context.Pokemons.Add(pokemon);
            context.SaveChanges();
            return GetAllPokemons();


        }

        public IEnumerable<Root> GetAllPokemons()
        {
            return context.Pokemons.ToList();
        }

        public Root GetPokemonByName(string pokemonName)
        {
            return context.Pokemons.FirstOrDefault(p => p.Name == pokemonName);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
