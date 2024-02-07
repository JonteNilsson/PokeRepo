﻿using Newtonsoft.Json;
using PokeRepo.Models;

namespace PokeRepo.API

{

    public class ApiCaller
    {
        public HttpClient? Client { get; set; }


      
        public ApiCaller()
        {
            Client = new();

            Client.BaseAddress = new Uri("https://pokeapi.co/docs/v2#pokemon");
        }

        public async Task<Root> MakeCall(string url)
        {
            HttpResponseMessage response = await Client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                Root? result = JsonConvert.DeserializeObject<Root>(json);

                if (result != null)
                {
                    return result;
                }
            }

            throw new HttpRequestException();
        }
    }

}
