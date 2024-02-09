using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeRepo.Models;

namespace PokeRepo.Pages
{

	public class IndexModel : PageModel
	{


		public string? ErrorMessage { get; set; }
		public Root? Pokemons { get; set; }




		public void OnGet()
		{


		}
	}
}
