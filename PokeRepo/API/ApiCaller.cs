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

        //public async Task<Root> MakeCall(string url)
        //{

        //}
    }
}
