 using System;
using startehouse.api.Domain.DTO;
using startehouse.api.Domain.Model;

namespace startehouse.api.Data
{
    public class PersonRepository : IPersonRepository
    {

        private readonly ConectionContext _context = new ConectionContext();

        public void Add(Person person)
        {
            _context.Person.Add(person);
            _context.SaveChanges();
        }

        public List<PersonDTO > Get(int pageNumber, int pageQuantity)
        {
            return _context.Person.Skip((pageNumber - 1) * pageQuantity)
                .Select(x =>
                new PersonDTO()
                {
                    Id = x.Id,
                    Nome = x.Nome,
                    Foto =x.Foto
                })
                 .ToList(); 
        }

        public Person? Get(int id)
        {
            return _context.Person.Find(id);
        }
    }
}

