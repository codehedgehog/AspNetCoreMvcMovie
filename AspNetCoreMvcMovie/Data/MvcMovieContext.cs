using Microsoft.EntityFrameworkCore;

namespace AspNetCoreMvcMovie.Models
{
	public class MvcMovieContext : DbContext
	{
		public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
				: base(options)
		{
		}

		public DbSet<AspNetCoreMvcMovie.Models.Movie> Movie { get; set; }
	}
}