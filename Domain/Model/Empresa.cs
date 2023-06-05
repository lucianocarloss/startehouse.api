using System;
using System.ComponentModel.DataAnnotations;

namespace startehouse.api.Domain.Model
{
	public class Empresas
	{
		[Key]
		public int Id { get; set; }
		public string? Nome { get; set; }
		public string? Razao { get; set; }
		public string? Endereco { get; set; }
		public string? Numero { get; set; }
		public string? Bairro { get; set; }
		public string? Cidade { get; set; }
		public string? Estado { get; set; }
        public string? Complemento { get; set; }
        public string? CNPJ { get; set; }
		public string? Telefone { get; set; }
		public string? Celular { get; set; }
		public string? Email { get; set; }
		public string? Contato { get; set; }
		public string? Tipo { get; set; }
        public int? Status { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataEdicao { get; set; }

        //public ICollection<Clientes>? Clientes { get; private set; }

		/*public Empresas(string Nome, string Razao, string Endereco, string Numero, string Bairro, string Cidade, string Estado, string Complemento, string CNPJ,
			string Telefone, string Celular, string Email, string Contato, string Tipo, int Status, DateTime DataCriacao, DateTime DataEdicao)
		{
			this.Nome = Nome;
			this.Razao = Razao;
			this.Endereco = Endereco;
			this.Numero = Numero;
			this.Bairro = Bairro;
			this.Cidade = Cidade;
			this.Estado = Estado;
			this.Complemento = Complemento;
			this.CNPJ = CNPJ;
			this.Telefone = Telefone;
			this.Celular = Celular;
			this.Email = Email;
			this.Contato = Contato;
			this.Tipo = Tipo;
            this.Status = Status;
            this.DataCriacao = DataCriacao;
            this.DataEdicao = DataEdicao;
        }*/
    }
}

