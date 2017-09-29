using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class Usuarios
	{
		[Key]
		public int UsuarioId { get; set; }
		public string Nombres { get; set; }
		public string Clave { get; set; }
		public string ConfirmarClave { get; set; }
		public DateTime Fecha { get; set; }

		public Usuarios()
		{

		}
	}
}
