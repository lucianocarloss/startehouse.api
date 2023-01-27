using System;
using startehouse.api.Model;

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

        public List<Person> Get()
        {
            return _context.Person.ToList();
        }
    }
}

