using BLL;
using Entidades;
using LibreriaCamilo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaCamiloWeb.UI.Registros
{
	public partial class rProductos : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		private void Limpiar()
		{
			ProductoIdTextBox.Text = "";
			DescripcionTextBox.Text = "";
			CostoTextBox.Text = "";
			PrecioTextBox.Text = "";
			CantidadTextBox.Text = "";
		}

		private Productos Llenar()
		{
			Productos producto = new Productos();
			producto.ProductoId = Utilidades.TOINT(ProductoIdTextBox.Text);
			producto.Descripcion = DescripcionTextBox.Text;
			producto.Costo = Utilidades.TOINT(CostoTextBox.Text);
			producto.Precio = Utilidades.TOINT(PrecioTextBox.Text);
			producto.Cantidad = Utilidades.TOINT(CantidadTextBox.Text);
			return producto;
		}

		protected void GuardarButton_Click(object sender, EventArgs e)
		{
			Productos producto = new Productos();
			int id = 0;
			producto = Llenar();
			if (id != producto.ProductoId)
			{
				ProductosBLL.Modificar(producto);
				Utilidades.ShowToastr(this, "Modificado", "Producto", "info");
				Limpiar();
			}
			else
			{
				ProductosBLL.Guardar(producto);
				Utilidades.ShowToastr(this, "Guardado", "Producto", "info");
				Limpiar();
			}
		}

		protected void EliminarButton_Click(object sender, EventArgs e)
		{
			int id = Utilidades.TOINT(ProductoIdTextBox.Text);

			if (ProductosBLL.Eliminar(ProductosBLL.Buscar(p => p.ProductoId == id)))
			{
				Utilidades.ShowToastr(this, "Eliminado", "Producto", "info");
				Limpiar();
			}
			else
			{
				Utilidades.ShowToastr(this, "No Eliminado", "Producto", "Error");
			}
		}

		protected void NuevoButton_Click(object sender, EventArgs e)
		{
			Limpiar();
		}

		protected void BuscarButton_Click(object sender, EventArgs e)
		{
			int id = Utilidades.TOINT(ProductoIdTextBox.Text);
			var producto = new Productos();

			producto = ProductosBLL.Buscar(p => p.ProductoId == id);

			if (producto != null)
			{
				DescripcionTextBox.Text = producto.Descripcion;
				CostoTextBox.Text = Convert.ToString(producto.Costo);
				PrecioTextBox.Text = Convert.ToString(producto.Precio);
				CantidadTextBox.Text = Convert.ToString(producto.Cantidad);
				Utilidades.ShowToastr(this, "Encontrado", "Producto", "info");
			}
			else
			{
				Utilidades.ShowToastr(this, "No Encontrado", "Producto", "Error");
				Limpiar();
			}
		}
	}

}