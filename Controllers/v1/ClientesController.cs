using System.Linq;
using System.Net.NetworkInformation;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using startehouse.api.Data;
using startehouse.api.Domain.DTO;
using startehouse.api.Domain.Model;
using startehouse.api.ViewModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace startehouse.api.Controllers.v1
{
    [ApiController]
    //[Route("[controller]")]
    [Route("api/Clientes")]
    [ApiVersion("1.0")]
    public class ClientesController : ControllerBase 
    {

        //private readonly IClientesRepository _clientesRepository;
        private readonly ILogger<ClientesController> _loggers;
        private readonly IMapper _mappers;
        private readonly ConectionContext _contexts = new ConectionContext();

        public ClientesController( ILogger<ClientesController> logger, IMapper mapper)
        {
            //_clientesRepository = clientesRepository ?? throw new ArgumentNullException(nameof(clientesRepository));
            _loggers = logger ?? throw new ArgumentNullException(nameof(logger));
            _mappers = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }




        //[Authorize]
        [HttpPost]
        // GET: /<controller>/
        public IActionResult Add([FromBody] Clientes _clientes)
        {
            try
            {

                _contexts.Clientes.Add(_clientes);
                _contexts.SaveChanges();

                return Ok(_clientes);

            }
            catch (Exception e)
            {
                return BadRequest("Erro ao carregar um novo usuario! " + e);
            }

        }


        //[Authorize]
        [HttpGet]
        public IActionResult Load()
        {
            //_logger.Log(LogLevel.Error, "Eita Porra!");

            //throw new Exception("Erro de Teste");
            
            var Empres = _contexts.Empresa.AsParallel().ToList();

            var result = _contexts.Clientes.Select(x => new
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
                Empresa = _contexts.Empresa.Where(w => w.Id == x.IdEmpresa).Select(y => new
                {
                    y.Id,
                    y.Nome,
                    y.Razao,
                    y.Endereco,
                    y.Numero,
                    y.Bairro,
                    y.Cidade,
                    y.Estado,
                    y.Complemento,
                    y.CNPJ,
                    y.Telefone,
                    y.Celular,
                    y.Email,
                    y.Contato,
                    y.Tipo,
                    y.Status,
                    y.DataCriacao,
                    y.DataEdicao

        }).ToList()
            }).ToList();


            //var clientes = _clientesRepository.Get();


            //_logger.LogInformation("Aconteceu um erro");

            return Ok(result);
        }

        
        
    }
}