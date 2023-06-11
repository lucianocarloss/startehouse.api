using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace startehouse.api.Domain.Model
{
    [Table("Usuarios")]
    public class Usuario
	{
		[Key]
		public int Id { get; set; }
		public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime UltimoLogin { get; set; }
		public int Status { get; set; }
		public int IdColaborador { get; set; }
		public int IdEmpresa { get; set; }
        public string UserName { get; set; }


        public Usuario(string Login, string Senha, DateTime UltimoLogin, int Status, int IdColaborador, int IdEmpresa, string UserName)
		{
			this.Login = Login ?? throw new ArgumentNullException(nameof(Login));
			this.Senha = Senha;
			this.UltimoLogin = UltimoLogin;
			this.Status = Status;
			this.IdColaborador = IdColaborador;
            this.IdEmpresa = IdEmpresa;
			this.UserName = UserName;
        }

        public Usuario()
        {
        }
    }
}

