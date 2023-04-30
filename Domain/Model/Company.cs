using System;
using System.ComponentModel.DataAnnotations;

namespace startehouse.api.Domain.Model
{
	public class Company
	{
		[Key]
		public int Id { get; set; }
		public string Nome { get; set; }

	}
}

