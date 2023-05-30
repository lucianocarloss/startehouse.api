using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace startehouse.api.Domain.Model
{
	public class Clientes
	{
		[Key]
		public int Id { get ; private set; }
		public string? Nome { get ; private set; }
		public string? Endereco { get ; private set; }
		public string? Numero { get; private set; }
		public string? Bairro { get; private set; }
		public string? Cidade { get; private set; }
		public string? Estado { get; private set; }
        public string? Complemento { get; private set; }
        public int? RG { get; private set; }
		public string? CPF { get; private set; }
		public string? Telefone { get; private set; }
		public string? Celular { get; private set; }
        public string? Celular_InstantMsg { get; private set; }
        public string? Email { get; private set; }
		public DateTime? Nascimento { get; private set; }
		public DateTime? DataCriacao { get; private set; }
		public DateTime? DataEdicao { get; private set; }
		public int? Status { get; private set; }

        public int? IdEmpresa { get; private set; }

		public virtual Empresas? Empresa { get; private set; }

        public Clientes(string Nome, string Endereco, string Numero, string Bairro, string Cidade, string Estado, string Complemento, int RG, string CPF,
			string Telefone, string Celular, string Celular_InstantMsg, string Email, DateTime Nascimento, DateTime DataCriacao, DateTime DataEdicao, int Status, int IdEmpresa, Empresas Empresa)
		{
			this.Nome = Nome ?? throw new ArgumentNullException(nameof(Nome));
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
			this.Empresa = Empresa;
		}

		public Clientes()
		{

		}
	}
}

