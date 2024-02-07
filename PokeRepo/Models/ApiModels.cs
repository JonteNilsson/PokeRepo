using Newtonsoft.Json;

namespace PokeRepo.Models
{
	public class Root
	{

		[JsonProperty("base_experience")]
		public int? BaseExperience { get; set; }

		[JsonProperty("height")]
		public int? Height { get; set; }

		[JsonProperty("id")]
		public int? Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("sprites")]
		public Sprites Sprites { get; set; }

		[JsonProperty("weight")]
		public int? Weight { get; set; }
	}


	public class Sprites
	{
		[JsonProperty("back_default")]
		public string BackDefault { get; set; }

		[JsonProperty("front_default")]
		public string FrontDefault { get; set; }
	}




