using BLL;
using Entidades;
using LibreriaCamilo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaCamiloWeb.UI.Consultas
{
	public partial class cUsuarios1 : System.Web.UI.Page
	{
		public static List<Usuarios> Lista { get; set; }

		protected void Page_Load(object sender, EventArgs e)
		{
            
			UsuariosGridView.DataBind();
		}

		protected void FiltrarButton_Click(object sender, EventArgs e)
		{
			UsuariosGridView.DataSource = UsuariosBLL.GetListAll();

			DateTime desde = DateTime.Now;
			DateTime hasta = DateTime.Now;



			if (UsuariosDropDownList.SelectedIndex == 0)
			{
				Lista = UsuariosBLL.GetListAll();
				UsuariosGridView.DataSource = Lista;
				UsuariosGridView.DataBind();
			}
			else
			if (UsuariosDropDownList.SelectedIndex == 1)
			{
                desde = Convert.ToDateTime(FechaunoTextBox.Text);
                hasta = Convert.ToDateTime(FechadosTextBox.Text);

                Lista = UsuariosBLL.GetList(p => p.Fecha >= desde.Date && p.Fecha <= hasta.Date);

				UsuariosGridView.DataSource = Lista;
				UsuariosGridView.DataBind();
			}
			else
			if (UsuariosDropDownList.SelectedIndex == 2)
			{

                UsuariosGridView.DataSource = UsuariosBLL.GetList(p => p.Nombres == FiltrarTextBox.Text);
                UsuariosGridView.DataBind();
			}
			else
			if (UsuariosDropDownList.SelectedIndex == 3)
			{
				int id = Utilidades.TOINT(FiltrarTextBox.Text);
				Lista = UsuariosBLL.GetList(p => p.UsuarioId == id);
				UsuariosGridView.DataSource = UsuariosBLL.GetList(p => p.UsuarioId == id);
				UsuariosGridView.DataBind();
			}

		}

		protected void ImprimirButton_Click(object sender, EventArgs e)
		{
			Response.Redirect("../Reportes/ReporteUsuario.aspx");
		}
	}
}