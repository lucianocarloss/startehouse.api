using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using startehouse.api.Domain.Model;

namespace startehouse.api.Services
{
	public class TokenService
	{
		public static object GenerateToken(Usuario Usuario, Empresas emp)
		{
			var key = Encoding.ASCII.GetBytes(Key.Secret);
			var tokenConfig = new SecurityTokenDescriptor
			{
				Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]
				{
					new Claim("usuarioId", Usuario.Id.ToString()),
                    new Claim("IdEmpresa", Usuario.IdEmpresa.ToString()),
                    new Claim("userName", Usuario.UserName.ToString()),
                    new Claim("empName", emp.Nome.ToString())
                }),
				Expires = DateTime.UtcNow.AddHours(3),
				SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
			};

			var tokenHandler = new JwtSecurityTokenHandler();
			var token = tokenHandler.CreateToken(tokenConfig);
			var tokenString = tokenHandler.WriteToken(token);


			return new
			{
				token = tokenString
			};
		}
	}
}

