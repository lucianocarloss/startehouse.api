using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using startehouse.api.Domain.DTO;
using startehouse.api.Domain.Model;
using startehouse.api.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace startehouse.api.Controllers.v1
{
    [ApiController]
    [Route("[controller]")]
    [ApiVersion("1.0")]
    public class PersonController : ControllerBase 
    {

        private readonly IPersonRepository _personRepository;
        private readonly ILogger<PersonController> _logger;
        private readonly IMapper _mapper;

        public PersonController(IPersonRepository personRepository, ILogger<PersonController> logger, IMapper mapper)
        {
            _personRepository = personRepository ?? throw new ArgumentNullException(nameof(personRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }





        //public PersonController(IPer sonRepository personRepository)
        //{
        //  _personRepository = personRepository ?? throw new ArgumentNullException(nameof(personRepository));
        //}


        [Authorize]
        [HttpPost]
        // GET: /<controller>/
        public IActionResult Add([FromForm] PersonViewModel personView)
        {
            var filePath = Path.Combine("Storage", personView.Foto.FileName);

            using Stream fileStream = new FileStream(filePath, FileMode.Create);
            personView.Foto.CopyTo(fileStream);

            var person = new Person(personView.Nome, personView.Telefone, personView.Email, personView.Ativo, filePath);
            _personRepository.Add(person);

            return Ok(person);
        }

        [Authorize]
        [HttpPost]
        [Route("{id}/download")]
        public IActionResult DownloadFotos(int id)
        {
            var person = _personRepository.Get(id);

            var dataBytes = System.IO.File.ReadAllBytes(person.Foto);

            return File(dataBytes, "image/png ");
        }

        //[Authorize]
        [HttpGet]
        public IActionResult Load(int pageNumber, int pageQuantity)
        {
            //_logger.Log(LogLevel.Error, "Eita Porra!");

            //throw new Exception("Erro de Teste");

            var person = _personRepository.Get(pageNumber, pageQuantity);

            //_logger.LogInformation("Aconteceu um erro");

            return Ok(person);
        }

        //[Authorize]
        [HttpGet]
        [Route("{Id}")]
        public IActionResult Search(int Id)
        {

            var person = _personRepository.Get(Id);

            var personsDTO = _mapper.Map <PersonDTO>(person);

            return Ok(personsDTO);
        }
    }
}