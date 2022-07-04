using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _2
{
	public class Table_context : DbContext
	{
		public Table_context() {
			Database.EnsureCreated();
		}

		public DbSet<MyTable> MyTables { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder options) {
			options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyDatabase1;Trusted_Connection=True;");
		}
	}
}