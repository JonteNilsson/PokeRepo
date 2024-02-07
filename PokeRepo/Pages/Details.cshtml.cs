using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeRepo.API;
using PokeRepo.Models;

namespace PokeRepo.Pages
{
	public class DetailsModel : PageModel
	{
		public string? ErrorMessage { get; set; }
		public Root? Pokemon { get; set; }



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


		}
	}
}
