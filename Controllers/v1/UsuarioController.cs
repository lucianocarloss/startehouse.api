//using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using startehouse.api.Data;
using startehouse.api.Domain.Model;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace startehouse.api.Controllers.v1
{
    [ApiController]
    [Route("[controller]")]
    [ApiVersion("1.0")]
    public class UsuarioController : ControllerBase 
    {

        //private readonly ILogger<UsuarioController> _logger;
        //private readonly IMapper _mapper;

        private readonly ConectionContext _contexts = new ConectionContext();

        /*public UsuarioController( ILogger<UsuarioController> logger, IMapper mapper)
        {
            //_personRepository = personRepository ?? throw new ArgumentNullException(nameof(personRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }*/





        //public PersonController(IPer sonRepository personRepository)
        //{
        //  _personRepository = personRepository ?? throw new ArgumentNullException(nameof(personRepository));
        //}


        //[Authorize]
        [HttpPost]
        //GET: /<controller>/
        public IActionResult Add([FromBody] Usuario _usuario)
        {
            //var filePath = Path.Combine("Storage", personView.Foto.FileName);

            //using Stream fileStream = new FileStream(filePath, FileMode.Create);
            //personView.Foto.CopyTo(fileStream);


            try
            {

                _contexts.Usuario.Add(_usuario);
                _contexts.SaveChanges();

                return Ok(_usuario);

            }
            catch (Exception e)
            {
                return BadRequest("Erro ao cadastrar novo usuario!");
            }
        }

        [Authorize]
        [NonAction]
        [HttpPost]
        [Route("{id}/download")]
        public IActionResult DownloadFotos(int Id)
        {
            var IdFoto = Id;

            var usuario = _contexts.Usuario.FirstOrDefault(x => x.Id == IdFoto);

            var dataBytes = System.IO.File.ReadAllBytes(usuario.Login);

            return File(dataBytes, "image/png ");
        }

        //[Authorize]
        [HttpGet]
        public IActionResult Load()
        {
            //_logger.Log(LogLevel.Error, "Eita Porra!");

            //throw new Exception("Erro de Teste");

            var Usuario = _contexts.Usuario.Select(x => new
            {
                Id = x.Id,
                Login = x.Login,
                Senha = x.Senha,
                UltimoLogin = x.UltimoLogin,
                Status = x.Status,
                IdColaborador = x.IdColaborador,
                IdEmpresa = x.IdEmpresa,
                UserName = x.UserName,
                Empresa = _contexts.Empresa.Where(w => w.Id == x.IdEmpresa).Select(y => new
                {
                    y.Id,
                    y.Nome

                }).ToList()
            }).ToList();

            //_logger.LogInformation("Aconteceu um erro");

            return Ok(Usuario);
        }

        //[Authorize]
        [HttpGet]
        [Route("{Id}")]
        public IActionResult Search(int Id)
        {

            var person = "";

            return Ok(person);
        }
    }
}