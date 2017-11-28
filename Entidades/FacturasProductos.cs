using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class FacturasProductos
    {
		[Key]
        public int Id { get; set; }
        public int FacturaId { get; set; }
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal Cantidad { get; set; }


        public Productos Producto { get; set; }

		public List<FacturasProductos> Detalle;
		public static List<FacturasProductos> impresion;

		public FacturasProductos()
        {
			Detalle = new List<FacturasProductos>();
			impresion = new List<FacturasProductos>();
		}

		public void AgregarDetalle(int productoId, int id, int facturaid, string descripcion, decimal precio, decimal cantidad)
		{
			this.Detalle.Add(new FacturasProductos(productoId,id, facturaid, descripcion, precio, cantidad));

			impresion = Detalle;
		}

		public FacturasProductos(int productoId,int id, int facturaid, string descripcion, decimal precio, decimal cantidad)
        {
            this.ProductoId = productoId;
            this.Descripcion = descripcion;
            this.Cantidad = cantidad;
            this.Precio = precio;
			this.Id = id;
			this.FacturaId = facturaid; 
			Detalle = new List<FacturasProductos>();
			impresion = new List<FacturasProductos>();
		}
    }
}
