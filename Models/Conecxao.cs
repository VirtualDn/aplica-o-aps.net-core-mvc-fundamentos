using System.Data.Entity;

namespace Funtametos_do.Models
{
	public class Conecxao : DbContext
	{
		public Conecxao():base("dbconect") { }

		public DbSet<Pessoa> Pessoa { get; set; }
	}
}
