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
	public partial class rUsuarios : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		private void Limpiar()
		{
			UsuarioIdTextBox.Text = "";
			NombreTextBox.Text = "";
			ClaveTextBox.Text = "";
			ConfirmarClaveTextBox.Text = "";
			FechaTextBox.Text = "";
		}

		private Usuarios Llenar()
		{
			Usuarios usuario = new Usuarios();
			usuario.UsuarioId = Utilidades.TOINT(UsuarioIdTextBox.Text);
			usuario.Nombres = NombreTextBox.Text;
			usuario.Clave = ClaveTextBox.Text;
			usuario.ConfirmarClave = ConfirmarClaveTextBox.Text;
			usuario.Fecha = Convert.ToDateTime(FechaTextBox.Text);
			return usuario;
		}


		protected void BuscarButton_Click(object sender, EventArgs e)
		{

			int id = Utilidades.TOINT(UsuarioIdTextBox.Text);
			var usuario = new Usuarios();

			usuario = UsuariosBLL.Buscar(p => p.UsuarioId == id);

			if (usuario != null)
			{
				NombreTextBox.Text = usuario.Nombres;
				ClaveTextBox.Text = usuario.Clave;
				ConfirmarClaveTextBox.Text = usuario.ConfirmarClave;
				FechaTextBox.Text = usuario.Fecha.ToString();
			}
			else
			{
				//MessageBox.Show("No existe.");
				Limpiar();
			}

		}

		protected void NuevoButton_Click(object sender, EventArgs e)
		{
			Limpiar();
		}

		protected void GuardarButton_Click(object sender, EventArgs e)
		{

			Usuarios usuario = new Usuarios();
			int id = 0;
			usuario = Llenar();
			if (ClaveTextBox.Text == ConfirmarClaveTextBox.Text)
			{
				if (id != usuario.UsuarioId)
				{
					UsuariosBLL.Modificar(usuario);
					//MessageBox.Show("Usuario modificado con exito");
				}
				else
				{
					UsuariosBLL.Guardar(usuario);
					//MessageBox.Show("Nuevo usuario agregado!");
				}
			}
			else
			{
				/*CamposVacioserrorProvider.SetError(ClavetextBox, "Campos no son iguales");
				CamposVacioserrorProvider.SetError(ConfirmartextBox, "Campos no son iguales");
				MessageBox.Show("CAMPOS No Coinciden");*/
			}
			//UsuariosBLL.Guardar(usuario);

		}

		protected void EliminarButton_Click(object sender, EventArgs e)
		{
			int id = Utilidades.TOINT(UsuarioIdTextBox.Text);

			if (UsuariosBLL.Eliminar(UsuariosBLL.Buscar(p => p.UsuarioId == id)))
			{
				Limpiar();
				//MessageBox.Show("El Usuario se elimino con exito.");
			}
			else
			{
				//MessageBox.Show("El Usuario no se pudo eliminar.");
			}
		}
	}
}