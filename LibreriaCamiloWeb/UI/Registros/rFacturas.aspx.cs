using BLL;
using Entidades;
using LibreriaCamilo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaCamiloWeb.UI.Registros
{
    public partial class rFacturas : System.Web.UI.Page
    {

        DataTable dt = new DataTable();
        Entidades.Productos producto = new Entidades.Productos();
        private static List<Entidades.FacturasProductos> listaRelaciones;
        Entidades.Facturas factura;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                dt.Columns.AddRange(new DataColumn[4] { new DataColumn("ID Producto"), new DataColumn("Descripcion"), new DataColumn("Precio"), new DataColumn("Cantidad") });
                ViewState["Detalle"] = dt;

                producto = new Entidades.Productos();
                listaRelaciones = new List<Entidades.FacturasProductos>();
                factura = new Entidades.Facturas();

            }
        }
        //Sirve para buscar 
        public void LlenarRegistro(List<Entidades.FacturasProductos> llenar)
        {
            foreach (var li in llenar)
            {
                dt = (DataTable)ViewState["Detalle"];
                dt.Rows.Add(li.ProductoId, li.Descripcion, li.Cantidad, li.Precio);
                ViewState["Detalle"] = dt;
                this.BindGrid();
            }
        }

        //ASigana datos a guardar
        public void LlenarDatos(Entidades.FacturasProductos detalle)
        {
            foreach (GridViewRow dr in FacturaGridView.Rows)
            {
                detalle.AgregarDetalle(Utilidades.TOINT(dr.Cells[0].Text),
                 dr.Cells[1].Text, Convert.ToDecimal(dr.Cells[2].Text), Convert.ToDecimal(dr.Cells[3].Text)
                   );
            }

            factura = new Entidades.Facturas(Convert.ToDateTime(FechaTextBox.Text),
                Convert.ToDecimal(SubtotalTextBox.Text), Convert.ToDecimal(ItbisTextBox.Text),
                Convert.ToDecimal(TotalTextBox.Text), Utilidades.TOINT(ClienteIdTextBox.Text), NombreTextBox.Text);
        }

        protected void BindGrid()
        {
            FacturaGridView.DataSource = (DataTable)ViewState["Detalle"];
            FacturaGridView.DataBind();
        }

        protected void BuscarClienteButton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.TOINT(ClienteIdTextBox.Text);
            var cliente = new Clientes();

            cliente = ClientesBLL.Buscar(p => p.ClienteId == id);

            if (cliente != null)
            {
                NombreTextBox.Text = cliente.Nombres;

            }
            else
            {
                Utilidades.ShowToastr(this, "Cliente no existe ", "Mensaje", "error");
            }

        }

        protected void BuscarProductoButton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.TOINT(ProductoIdTextBox.Text);
            var producto = new Productos();

            producto = ProductosBLL.Buscar(p => p.ProductoId == id);

            if (producto != null)
            {
                DescripcionTextBox.Text = producto.Descripcion;

                PrecioTextBox.Text = Convert.ToString(producto.Precio);

            }
            else
            {
                Utilidades.ShowToastr(this, "Producto no existe ", "Mensaje", "error");
            }
        }

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.TOINT(ProductoIdTextBox.Text);
            producto = BLL.ProductosBLL.Buscar(p => p.ProductoId == id);

            if (Utilidades.TOINT(CantidadTextBox.Text) > producto.Cantidad)
            {
                Utilidades.ShowToastr(this, "Cantidad execede existencia", "info");
            }
            else
            {
                bool agregado = false;

                foreach (GridViewRow pro in FacturaGridView.Rows)
                {
                    int prueba = Utilidades.TOINT(pro.Cells[0].Text);
                    if (producto.ProductoId == Utilidades.TOINT(pro.Cells[0].Text))
                    {
                        agregado = true;
                        break;
                    }
                }
                if (agregado)
                {

                    Utilidades.ShowToastr(this, " Articulo ya esta en factura -Selecione otro", "Error", "info");

                }
                else
                {
                    DataTable dt = (DataTable)ViewState["Detalle"];
                    dt.Rows.Add(ProductoIdTextBox.Text, producto.Descripcion.Trim(), producto.Precio, CantidadTextBox.Text.Trim());
                    ViewState["Detalle"] = dt;
                    this.BindGrid();
                    CalcularMonto();
                }
            }
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Entidades.FacturasProductos detallef = new Entidades.FacturasProductos();
            LlenarDatos(detallef);

            if (detallef.Detalle.Count == 0)
            {
                Utilidades.ShowToastr(this, "Primero agregue Articulos", "Consejo", "info");

            }
            else
            {
                if (BLL.FacturasBLL.Guardar(factura, detallef.Detalle))
                {
                    Utilidades.ShowToastr(this, "Guardo", "Correcto", "success");
                }
                else
                {
                    Utilidades.ShowToastr(this, "Error", "Error", "error");

                }
            }
        }

        private void Limpiar()
        {
            dt.Columns.AddRange(new DataColumn[4] { new DataColumn("ID Producto"), new DataColumn("Descripcion"), new DataColumn("Precio"), new DataColumn("Cantidad") });
            ViewState["Detalle"] = dt;

            this.BindGrid();

            TotalTextBox.Text = "";
            ClienteIdTextBox.Text = "";
            NombreTextBox.Text = "";
            ProductoIdTextBox.Text = "";
            DescripcionTextBox.Text = "";
            PrecioTextBox.Text = "";
            CantidadTextBox.Text = "";
            SubtotalTextBox.Text = "";
            ItbisTextBox.Text = "";
            TotalTextBox.Text = "";
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            var factura = new Facturas();

            if (string.IsNullOrWhiteSpace(FacturaIdTextBox.Text))
            {
                Utilidades.ShowToastr(this, "ID Vacio", "Resultados", "error");
            }
            else
            {
                int id = Utilidades.TOINT(FacturaIdTextBox.Text);

                factura = BLL.FacturasBLL.Buscar(f => f.FacturaId == id);
                if (factura != null)
                {
                    Limpiar();

                    Entidades.Clientes cli = new Clientes();
                    listaRelaciones = BLL.FacturasProductosBLL.GetList(A => A.FacturaId == factura.FacturaId);

                    if (factura != null)
                    {
                        if (listaRelaciones.Count == 0)
                        {
                            Utilidades.ShowToastr(this, "No se ha registrado Producto con este ID", "Resultados", "error");
                        }
                        else
                        {
                            LlenarRegistro(listaRelaciones);
                            NombreTextBox.Text = factura.NombreCliente;
                            SubtotalTextBox.Text = Convert.ToString(factura.SubTotal);
                            ItbisTextBox.Text = Convert.ToString(factura.Itbis);
                            TotalTextBox.Text = Convert.ToString(factura.Total);
                            FechaTextBox.Text = factura.Fecha.ToString("yyyy-MM-dd");

                            Utilidades.ShowToastr(this, "Sus Resultados", "Resultados", "success");  
                        }
                    }
                }
                else
                {
                    Utilidades.ShowToastr(this, "No existe factura", "Error", "error");
                }
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FacturaIdTextBox.Text))
            {

                Utilidades.ShowToastr(this, "Campo Id Vacio", "Error", "info");
            }
            else
            {
                int id = Utilidades.TOINT(FacturaIdTextBox.Text);

                factura = BLL.FacturasBLL.Buscar(f => f.FacturaId == id);

                if (factura != null)
                {
                    if (BLL.FacturasBLL.EliminarRelacion(factura))
                    {

                        Limpiar();

                        factura = new Entidades.Facturas();
                        Utilidades.ShowToastr(this, "Elimino Correctamente", "ELIMINADO", "success");

                    }
                    else
                    {
                        Utilidades.ShowToastr(this, "Problemas Al Eliminar", "Error", "error");
                    }

                }
                else
                {
                    Utilidades.ShowToastr(this, "No hay Factura", "Informacion", "info");
                }
            }
        }



        public void CalcularMonto()
        {
            decimal total = 0;
            decimal subTotal = 0m;
            decimal itbis = 0;

            /*foreach (GridViewRow precio in FacturaGridView.Rows)
            {

                subTotal += Convert.ToDecimal(PrecioTextBox.Text);
                itbis += (subTotal * 0.18m);
                total += (subTotal + itbis);

                SubtotalTextBox.Text = Convert.ToString(subTotal);
                TotalTextBox.Text = Convert.ToString(total);
                ItbisTextBox.Text = Convert.ToString(itbis);
            }*/

            if (FacturaGridView.Rows.Count > 0)
             {
                 foreach (GridViewRow precio in FacturaGridView.Rows)
                 {
                     Math.Round(subTotal += Convert.ToDecimal(precio.Cells[2].Text));
                     Math.Round(itbis += (subTotal * 0.18m));
                     Math.Round(total += (itbis + subTotal));

                    SubtotalTextBox.Text = subTotal.ToString();
                    ItbisTextBox.Text = itbis.ToString();
                    TotalTextBox.Text = total.ToString();

                 }
             }
            
             /*if (DescuentoTextBox.Text == "")
             {
                 DescuentoTextBox.Text = Convert.ToString(0);
             }
             else
             {
                 if (TextBoxSubTotal.Text == "")
                 {
                     Utilidades.ShowToastr(this, "Primero Agregue articulos", "ANTENCION ", "info");
                 }
                 else
                 {
                     descuento = ((Convert.ToDecimal(DescuentoTextBox.Text) / porciento) * Convert.ToDecimal(TextBoxSubTotal.Text));
                     Math.Round(total = (subTotal + itbs) - descuento);
                     TextBoxTotal.Text = total.ToString();
                 }*/



        }
        }
    }
