 using System;
using startehouse.api.Domain.Model;

namespace startehouse.api.Domain.DTO
{
	public class ClientesDTO
	{
        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Endereco { get; set; }

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

        public Empresas? Empresa { get; set; }
    }
}

