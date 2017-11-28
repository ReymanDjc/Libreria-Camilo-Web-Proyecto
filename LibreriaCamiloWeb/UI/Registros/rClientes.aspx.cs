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
	public partial class rClientes : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{


		}

		private void Limpiar()
		{
			ClienteIdTextBox.Text = "";
			NombreTextBox.Text = "";
			DireccionTextBox.Text = "";
			EmailTextBox.Text = "";
			TelefonoTextBox.Text = "";
		}

		private Clientes Llenar()
		{
			Clientes cliente = new Clientes();
			cliente.ClienteId = Utilidades.TOINT(ClienteIdTextBox.Text);
			cliente.Nombres = NombreTextBox.Text;
			cliente.Direccion = DireccionTextBox.Text;
			cliente.Email = EmailTextBox.Text;
			cliente.Telefono = TelefonoTextBox.Text;
			return cliente;
		}

		protected void GuardarButton_Click(object sender, EventArgs e)
		{
			Clientes cliente = new Clientes();
			int id = 0;
			cliente = Llenar();
			if (id != cliente.ClienteId)
			{
				ClientesBLL.Modificar(cliente);
				Utilidades.ShowToastr(this, "Modificado", "Cliente", "info");
				Limpiar();
			}
			else
			{
				ClientesBLL.Guardar(cliente);
				Utilidades.ShowToastr(this, "Guardado", "Cliente", "info");
				Limpiar();
			}

		}

		protected void EliminarButton_Click(object sender, EventArgs e)
		{
			int id = Utilidades.TOINT(ClienteIdTextBox.Text);

			if (ClientesBLL.Eliminar(ClientesBLL.Buscar(p => p.ClienteId == id)))
			{
				Utilidades.ShowToastr(this, "Eliminado", "Cliente", "info");
				Limpiar();
			}
			else
			{
				Utilidades.ShowToastr(this, "No Eliminado", "Cliente", "error");
			}
		}

		protected void NuevoButton_Click(object sender, EventArgs e)
		{
			Limpiar();
		}

		protected void BuscarButton_Click(object sender, EventArgs e)
		{
			int id = Utilidades.TOINT(ClienteIdTextBox.Text);
			var cliente = new Clientes();

			cliente = ClientesBLL.Buscar(p => p.ClienteId == id);

			if (cliente != null)
			{
				NombreTextBox.Text = cliente.Nombres;
				DireccionTextBox.Text = cliente.Direccion;
				EmailTextBox.Text = cliente.Email;
				TelefonoTextBox.Text = cliente.Telefono;
				Utilidades.ShowToastr(this, "Encontrado", "Cliente", "info");
			}
			else
			{
				Utilidades.ShowToastr(this, "No Encontrado", "Cliente", "error");
				Limpiar();
			}

		}
	}
}