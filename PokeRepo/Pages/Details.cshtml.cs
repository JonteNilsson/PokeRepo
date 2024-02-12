using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeRepo.API;
using PokeRepo.Database;
using PokeRepo.Models;
using PokeRepo.Services;

namespace PokeRepo.Pages
{
    public class DetailsModel : PageModel
    {

        private PokemonRepository _PokemonRepository;
        public string? ErrorMessage { get; set; }
        public Root? Pokemon { get; set; }

        private readonly AppDbContext _context;

        public DetailsModel(AppDbContext context, IPokemonRepository pokemonRepository)
        {
            _context = context;
            _PokemonRepository = (PokemonRepository)pokemonRepository;



        }


        public async Task OnGet(string pokemonName)
        {
            try
            {
                Pokemon = await new ApiCaller().MakeCall($"pokemon/{pokemonName.ToLower()}");

            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }

            _PokemonRepository.AddPokemon(Pokemon);
            _context.SaveChanges();


        }
    }
}
