using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace _2._1
{
	class ContextApp:DbContext
	{
		public ContextApp() {
			Database.EnsureDeleted();
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder option) {
			option.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TestDB1;Trusted_Connection=True;");
		}
		public DbSet<Account> Accounts { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Product> Products { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			modelBuilder.Entity<Account>()
				.HasMany(u => u.Customers)
				.WithMany(p => p.Accounts);
			modelBuilder.Entity<Product>()
				.HasMany(q => q.Accounts)
				.WithMany(h => h.Products);

		}
	}
}
