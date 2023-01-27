using System;
using Microsoft.EntityFrameworkCore;
using startehouse.api.Model;

namespace startehouse.api.Data
{
	public class ConectionContext: DbContext
	{
		public DbSet<Person> Person { get; set; }



		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			=> optionsBuilder.UseMySQL("server=localhost;database=start_house;user=root;password=root"); 
	}
}

