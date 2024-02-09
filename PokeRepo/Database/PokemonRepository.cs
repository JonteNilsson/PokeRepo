using Microsoft.EntityFrameworkCore;

namespace PokeRepo.Database
{
	public class PokemonRepository<T> where T : class
	{
		private readonly AppDbContext _context;

		private readonly DbSet<T> _dbSet;

		public PokemonRepository(AppDbContext context)
		{
			_context = context;
			_dbSet = context.Set<T>();
		}

		public void AddPokemon(T entity)
		{
			_dbSet.Add(entity);
		}
	}
}
