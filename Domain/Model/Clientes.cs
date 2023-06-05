using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace startehouse.api.Domain.Model
{
    [Table("Clientes")]
    public class Clientes
	{
		[Key]
		public int Id { get ; set; }
		public string? Nome { get ; set; }
		public string? Endereco { get ; set; }
		public string? Numero { get; set; }
		public string? Bairro { get; set; }
		public string? Cidade { get; set; }
		public string? Estado { get; set; }
        public string? Complemento { get; set; }
        public int? RG { get; set; }
		public string? CPF { get; set; }
		public string? Telefone { get; set; }
		public string? Celular { get; set; }
        public string? Celular_InstantMsg { get; set; }
        public string? Email { get; set; }
		public DateTime? Nascimento { get; set; }
		public DateTime? DataCriacao { get; set; }
		public DateTime? DataEdicao { get; set; }
		public int? Status { get; set; }
        public int? IdEmpresa { get; set; }

		//public virtual Empresas? Empresa { get; private set; }

        public Clientes( string Nome, string Endereco, string Numero, string Bairro, string Cidade, string Estado, string Complemento, int RG, string CPF,
			string Telefone, string Celular, string Celular_InstantMsg, string Email, DateTime Nascimento, DateTime DataCriacao, DateTime DataEdicao, int Status, int IdEmpresa)
		{
            this.Nome = Nome;
            this.Endereco = Endereco;
			this.Numero = Numero;
			this.Bairro = Bairro;
			this.Cidade = Cidade;
			this.Estado = Estado;
            this.Complemento = Complemento;
            this.RG = RG;
			this.CPF = CPF;
			this.Telefone = Telefone;
			this.Celular = Celular;
			this.Celular_InstantMsg = Celular_InstantMsg;
			this.Email = Email;
			this.Nascimento = Nascimento;
			this.DataCriacao = DataCriacao;
			this.DataEdicao = DataEdicao;
			this.Status = Status;
			this.IdEmpresa = IdEmpresa;
			//this.Empresa = Empresa;
		}

		public Clientes()
		{

		}
	}
}

