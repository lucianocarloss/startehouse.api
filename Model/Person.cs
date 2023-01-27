using System;
using System.ComponentModel.DataAnnotations;

namespace startehouse.api.Model
 {
	public class Person
	{
		[Key]
		public int Id { get; private set; }
		public string Nome { get; private set; }
		public string Telefone { get; private set; }
		public string Email { get; private set; }
		public int Ativo { get; private set; }


		public Person(string Nome, string Telefone, string Email, int Ativo)
		{
			this.Nome = Nome ?? throw new ArgumentNullException(nameof(Nome));
			this.Telefone = Telefone;
			this.Email = Email;
			this.Ativo = Ativo;
		}
	}
}

