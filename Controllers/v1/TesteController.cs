using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using startehouse.api.Data;
using startehouse.api.Domain.DTO;
using startehouse.api.Domain.Model;
using startehouse.api.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace startehouse.api.Controllers.v1
{
    [ApiController]
    [Route("[controller]")]
    [ApiVersion("1.0")]
    public class TesteController : ControllerBase 
    {

        //private readonly IPersonRepository _personRepository;
        private readonly ILogger<TesteController> _logger;
        private readonly IMapper _mapper;
        private readonly ConectionContext _contexts = new ConectionContext();

        public TesteController( ILogger<TesteController> logger, IMapper mapper)
        {
            //_personRepository = personRepository ?? throw new ArgumentNullException(nameof(personRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }





        //public PersonController(IPer sonRepository personRepository)
        //{
        //  _personRepository = personRepository ?? throw new ArgumentNullException(nameof(personRepository));
        //}


        //[Authorize]
        [HttpPost]
        //GET: /<controller>/
        public IActionResult Add( [FromBody] Teste personView)
        {
            try {

                _contexts.Teste.Add(personView);
                _contexts.SaveChanges();

                return Ok("Passou Direto! " + personView);

            }
            catch (Exception e)
            {
                return BadRequest("Erro ao carregar um novo usuario! "+e);
            }
        }

        
    }
}