﻿using System;
using Microsoft.EntityFrameworkCore;
using startehouse.api.Domain.Model;

namespace startehouse.api.Data
{
	public class ConectionContext: DbContext
	{
		public DbSet<Person> Person { get; set; }

        public DbSet<Company> Company { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			//=> optionsBuilder.UseMySQL("server=starthouse.mysql.database.azure.com;database=start_house;user=ponygon;password=Merumerumei24"); 
			=> optionsBuilder.UseMySQL("server=localhost;database=start_house;user=root;password=root"); 
	}
}

