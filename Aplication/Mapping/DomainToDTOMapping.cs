 using System;
using AutoMapper;
using startehouse.api.Domain.DTO;
using startehouse.api.Domain.Model;

namespace startehouse.api.Aplication.Mapping
{
	public class DomainToDTOMapping : Profile
	{
		public DomainToDTOMapping()
		{
			CreateMap<Person, PersonDTO>();

			CreateMap<Clientes, ClientesDTO>();
		}
	}
}

