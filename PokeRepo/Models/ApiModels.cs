using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PokeRepo.Models
{
	public class Root
	{
		[Key]
		public int Id { get; set; }

		[JsonProperty("name")]
		public string? Name { get; set; }

		[JsonProperty("height")]
		public int? Height { get; set; }

		[JsonProperty("weight")]
		public int? Weight { get; set; }

		[JsonProperty("base_experience")]
		public int? BaseExperience { get; set; }


		[JsonProperty("sprites")]
		public Sprites? Sprites { get; set; }
	}


	public class Sprites
	{
		[Key]
		public int Id { get; set; }

		[JsonProperty("back_default")]
		public string? BackDefault { get; set; }

		[JsonProperty("front_default")]
		public string? FrontDefault { get; set; }
	}
}




