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
    public partial class cFacturas : System.Web.UI.Page
    {
        public static List<Facturas> Lista { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            FacturaGridView.DataBind();
        }

        protected void FiltrarButton_Click(object sender, EventArgs e)
        {
            FacturaGridView.DataSource = FacturasBLL.GetListAll();

            DateTime desde = DateTime.Now;
            DateTime hasta = DateTime.Now;



            if (FacturaDropDownList.SelectedIndex == 0)
            {
                Lista = FacturasBLL.GetListAll();
                FacturaGridView.DataSource = Lista;
                FacturaGridView.DataBind();
            }
            else
            if (FacturaDropDownList.SelectedIndex == 2)
            {
                desde = Convert.ToDateTime(FechaunoTextBox.Text);
                hasta = Convert.ToDateTime(FechadosTextBox.Text);

                Lista = FacturasBLL.GetList(p => p.Fecha >= desde.Date && p.Fecha <= hasta.Date);

                FacturaGridView.DataSource = Lista;
                FacturaGridView.DataBind();
            }
            else
            if (FacturaDropDownList.SelectedIndex == 1)
            {
                int id = Utilidades.TOINT(FiltrarTextBox.Text);
                Lista = FacturasBLL.GetList(p => p.FacturaId == id);
                if (FiltrarTextBox.Text != "")
                {
                    FacturaGridView.DataSource = FacturasBLL.GetList(p => p.FacturaId == id);
                    FacturaGridView.DataBind();
                }
                else
                {
                    Utilidades.ShowToastr(this, "Factura no Encontrada", "Factura", "error");

                }
            }
            else
            if (FacturaDropDownList.SelectedIndex == 3)
            {
                int id = Utilidades.TOINT(FiltrarTextBox.Text);
                Lista = FacturasBLL.GetList(p => p.ClienteId == id);
                if (FiltrarTextBox.Text != "")
                {
                    FacturaGridView.DataSource = FacturasBLL.GetList(p => p.ClienteId == id);
                    FacturaGridView.DataBind();
                }
                else
                {
                    Utilidades.ShowToastr(this, "Factura no Encontrada", "Factura", "error");
                }  
            }
            else
            if (FacturaDropDownList.SelectedIndex == 4)
            {
                if (FiltrarTextBox.Text != "")
                {
                    FacturaGridView.DataSource = FacturasBLL.GetList(p => p.NombreCliente == FiltrarTextBox.Text);
                    FacturaGridView.DataBind();
                }
                else
                {
                    Utilidades.ShowToastr(this, "Factura no Encontrada", "Factura", "error");
                }
            }

            FiltrarTextBox.Text = "";
        }

        protected void ImprimirButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Reportes/ReporteFactura.aspx");
        }
    }
}


