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
	public partial class cProductos : System.Web.UI.Page
	{
		public static List<Productos> Lista { get; set; }
		protected void Page_Load(object sender, EventArgs e)
		{
			ProductosGridView.DataBind();
		}

		protected void FiltrarButton_Click(object sender, EventArgs e)
		{
			ProductosGridView.DataSource = ProductosBLL.GetListAll();

			if (ProductosDropDownList.SelectedIndex == 0)
			{
				Lista = ProductosBLL.GetListAll();
				ProductosGridView.DataSource = Lista;
				ProductosGridView.DataBind();
			}
			else
			if (ProductosDropDownList.SelectedIndex == 1)
			{
				int id = Utilidades.TOINT(FiltrarTextBox.Text);
				Lista = ProductosBLL.GetList(p => p.ProductoId == id);
				ProductosGridView.DataSource = ProductosBLL.GetList(p => p.ProductoId == id);
				ProductosGridView.DataBind();
			}
			else
			if (ProductosDropDownList.SelectedIndex == 2)
			{
				ProductosGridView.DataSource = ProductosBLL.GetList(p => p.Descripcion == FiltrarTextBox.Text);
				ProductosGridView.DataBind();
			}
		}

		protected void ImprimirButton_Click(object sender, EventArgs e)
		{
			Response.Redirect("../Reportes/ReporteProducto.aspx");
		}
	}
}