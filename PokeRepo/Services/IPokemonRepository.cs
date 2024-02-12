using PokeRepo.Models;

namespace PokeRepo.Services
{
    public interface IPokemonRepository
    {
        public IEnumerable<Root> AddPokemon(Root pokemon);

        public Root GetPokemonByName(string name);

        public IEnumerable<Root> GetAllPokemons();
    }
}
