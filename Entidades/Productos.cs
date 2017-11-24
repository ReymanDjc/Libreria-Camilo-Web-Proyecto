using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class Productos
	{

		[Key]
		public int ProductoId { get; set; }
		public string Descripcion { get; set; }
		public decimal Costo { get; set; }
		public decimal Precio { get; set; }
		public decimal Cantidad { get; set; }


		//public virtual ICollection<FacturasProductos> Relacion { get; set; }

		public Productos()
		{
			//this.Relacion = new HashSet<FacturasProductos>();
		}
	}
}
