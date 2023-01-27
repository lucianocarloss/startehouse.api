using System;
namespace startehouse.api.Model
{
	public interface IPersonRepository
	{
		void Add(Person person);

		List<Person> Get();
	}
}

