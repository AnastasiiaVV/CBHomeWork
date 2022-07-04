using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace _2
{
	class ContextApp: DbContext
	{
		public ContextApp() {
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder option) {
			option.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TestDB;Trusted_Connection=True;");
		}
		public DbSet<User> Users { get; set; }
		public DbSet<Office> Offices { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			modelBuilder.Entity<Office>()
			.HasOne(u => u.User).WithOne(p => p.Office)
			.HasForeignKey<User>(up => up.OfficeId);
		}

	}
}
