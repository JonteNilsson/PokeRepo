using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeRepo.Enum;

namespace PokeRepo.Pages
{
    public class IndexModel : PageModel
    {

        public string? ErrorMessage { get; set; }
        public Pokemons Pokemons { get; set; }


        public List
        public void OnGet()
        {

        }
    }
}
