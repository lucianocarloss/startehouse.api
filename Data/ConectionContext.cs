using System;
using Microsoft.EntityFrameworkCore;
using startehouse.api.Domain.Model;

namespace startehouse.api.Data
{
	public class ConectionContext : DbContext
	{
		public DbSet<Usuario>? Usuario { get; set; }

        public DbSet<Teste> Teste { get; set; }

        public DbSet<Clientes> Clientes { get; set; }

		public DbSet<Empresas> Empresa { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            //=> optionsBuilder.UseMySQL("server=starthouse.mysql.database.azure.com;database=start_house;user=ponygon;password=Merumerumei24"); 
            => optionsBuilder.UseMySQL("server=localhost;database=start_house;user=root;password=root");
            //=> optionsBuilder.UseNpgsql("User ID=postgres;Password=root;Host=localhost;Port=5432;Database=starthouse;");
            //=> optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Pooling=true;Database=starthouse;User ID=postgres;Password=root;");
            /*=> optionsBuilder.UseNpgsql(
                "server=localhost;" +
                "Port=5432;Database=starthouse;"+
                "User ID=postgres;" +
                "Password=root;");*/
    }

}