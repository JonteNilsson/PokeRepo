using Newtonsoft.Json;
using PokeRepo.Models;

namespace PokeRepo.API

{

    public class ApiCaller
    {
        public HttpClient? Client { get; set; }



        public ApiCaller()
        {
            Client = new();

            Client.BaseAddress = new Uri("https://pokeapi.co/api/v2/");
        }

        public async Task<Root> MakeCall(string url)
        {
            HttpResponseMessage response = await Client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                Root? result = JsonConvert.DeserializeObject<Root>(json);
                result.Id = 0;

                if (result != null)
                {
                    return result;
                }
            }

            throw new HttpRequestException();
        }
    }

}
