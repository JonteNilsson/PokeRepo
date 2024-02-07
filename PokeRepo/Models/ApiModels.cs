namespace PokeRepo.Models
{
    public class Root
    {
        public int Total { get; set; }
        public int Skip { get; set; }

        public int Limit { get; set; }

    }

    public class Pokemon
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
    }
}
