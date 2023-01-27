using Microsoft.AspNetCore.Mvc;
using startehouse.api.Model;
using startehouse.api.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace startehouse.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase 
    {

        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository ?? throw new ArgumentNullException(nameof(personRepository));
        }


        [HttpPost]
        // GET: /<controller>/
        public IActionResult Add(PersonViewModel personView)
        {
            var person = new Person(personView.Nome, personView.Telefone, personView.Email, personView.Ativo);
            _personRepository.Add(person);

            return Ok(person);
        }


        [HttpGet]
        public IActionResult Load()
        {
            var person = _personRepository.Get();
            return Ok(person);
        }
    }
}

