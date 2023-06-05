 using System;
using startehouse.api.Domain.DTO;
using startehouse.api.Domain.Model;

namespace startehouse.api.Data
{
    /*public class ClientesRepository : IClientesRepository
    {

        private readonly ConectionContext _contexts = new ConectionContext();

        public void Add(Clientes clientes)
        {
            _contexts.Add(clientes);
            _contexts.SaveChanges();
        }

        public List<ClientesDTO> Get()
        {
            return _contexts.Clientes
                .Select(x =>
                new ClientesDTO()
                {
                    Id = x.Id,
                    Nome = x.Nome,
                    Endereco = x.Endereco,
                    Numero = x.Numero,
                    Bairro = x.Bairro,
                    Cidade = x.Cidade,
                    Estado = x.Estado,
                    Complemento = x.Complemento,
                    RG = x.RG,
                    CPF = x.CPF,
                    Telefone = x.Telefone,
                    Celular = x.Celular,
                    Celular_InstantMsg = x.Celular_InstantMsg,
                    Email = x.Email,
                    Nascimento = x.Nascimento,
                    DataCriacao = x.DataCriacao,
                    DataEdicao = x.DataEdicao,
                    Status = x.Status,
                    IdEmpresa = x.IdEmpresa,
                    //Empresa = x.Empresa
                })
                .ToList();
        }



        public Clientes? Get(int id)
        {
            return _contexts.Clientes.Find(id);
        }
    }*/
}

