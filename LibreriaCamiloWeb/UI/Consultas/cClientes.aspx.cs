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
	public partial class cClientes : System.Web.UI.Page
	{
		public static List<Clientes> Lista { get; set; }

		protected void Page_Load(object sender, EventArgs e)
		{
			ClientesGridView.DataBind();
		}

		protected void FiltrarButton_Click(object sender, EventArgs e)
		{
			ClientesGridView.DataSource = ClientesBLL.GetListAll();

			if (ClientesDropDownList.SelectedIndex == 0)
			{
				Lista = ClientesBLL.GetListAll();
				ClientesGridView.DataSource = Lista;
				ClientesGridView.DataBind();
			}
			else
			if (ClientesDropDownList.SelectedIndex == 1)
			{
				int id = Utilidades.TOINT(FiltrarTextBox.Text);
				Lista = ClientesBLL.GetList(p => p.ClienteId == id);
				ClientesGridView.DataSource = ClientesBLL.GetList(p => p.ClienteId == id);
				ClientesGridView.DataBind();
			}
			else
			if (ClientesDropDownList.SelectedIndex == 2)
			{
				ClientesGridView.DataSource = ClientesBLL.GetList(p => p.Nombres == FiltrarTextBox.Text);
				ClientesGridView.DataBind();
			}
		}
	}
}