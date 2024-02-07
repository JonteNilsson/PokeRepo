using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeRepo.Enum;

namespace PokeRepo.Pages
{
	public class IndexModel : PageModel
	{

		public Pokemons Pokemons { get; set; }


		public void OnGet()
		{

		}
	}
}
