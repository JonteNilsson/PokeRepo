using Microsoft.EntityFrameworkCore;
using PokeRepo.Models;

namespace PokeRepo.Database
{
	public class AppDbContext : DbContext
	{
		public DbSet<Root> Pokemons { get; set; }

		public DbSet<Sprites> Images { get; set; }

		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}
	}
}
