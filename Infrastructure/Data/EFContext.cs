using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
	public class EFContext : DbContext
	{
		public EFContext(DbContextOptions<EFContext> options) : base(options)
		{

		}

		public DbSet<Domain.Libraries.Books.Author> Authors { get; set; }
		public DbSet<Domain.Libraries.Books.Book> Books { get; set; }
		public DbSet<Domain.Libraries.Books.Category> Categories { get; set; }
		public DbSet<Domain.Libraries.Books.Item> Items { get; set; }
		public DbSet<Domain.Libraries.Books.PublishHouse> PublishHouse { get; set; }
		public DbSet<Domain.Libraries.library> Librarys { get; set; }
		public DbSet<Domain.Members.Books.LoandBook> LoandBook { get; set; }
		public DbSet<Domain.Members.Users.User> Users { get; set; }	



	}
}
