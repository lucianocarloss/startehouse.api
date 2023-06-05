using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace startehouse.api.Domain.Model
 {

    [Table("Teste")]
    public class Teste
	{
		[Key]
		public int Id { get; private set; }
		public string? Nome { get; set; }


		public Teste(string Nome)
		{
			this.Nome = Nome ?? throw new ArgumentNullException(nameof(Nome));
        }

        public Teste()
        {
        }
    }
}

