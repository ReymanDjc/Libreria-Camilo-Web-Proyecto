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

		Entidades.Productos artig = new Entidades.Productos();
		private static List<Entidades.Productos> listadoArticulos = null;



		private static List<Entidades.FacturasProductos> listaRelaciones;
		Entidades.Facturas facturaG;

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{

				

				dt.Columns.AddRange(new DataColumn[4] { new DataColumn("ID Producto"), new DataColumn("Descripcion"), new DataColumn("Precio"), new DataColumn("Cantidad")});
				ViewState["Detalle"] = dt;

				artig = new Entidades.Productos();

				listadoArticulos = new List<Entidades.Productos>();
				listaRelaciones = new List<Entidades.FacturasProductos>();

				facturaG = new Entidades.Facturas();
				
			}

			



		}
		//Sirve para buscar 
		public void LlenarRegistro(List<Entidades.FacturasProductos> llenar)
		{

			foreach (var li in llenar)
			{
				DataTable dt = (DataTable)ViewState["Detalle"];
				dt.Rows.Add(li.ProductoId, li.Descripcion, li.Cantidad, li.Precio);
				ViewState["Detalle"] = dt;
				this.BindGrid();
			}


		}

		//ASigana datos a guardar
		public void LlenarDatos(Entidades.FacturasProductos detalle)
		{

			int id = 0;
			int idCliente = 0;
			int cantidad = 0;

			idCliente = Utilidades.TOINT(ClienteIdTextBox.Text);
			var clientec = BLL.ClientesBLL.Buscar(p => p.ClienteId == idCliente);

			if (facturaG != null)
			{
				id = facturaG.FacturaId;

			}

			foreach (GridViewRow dr in FacturaGridView.Rows)
			{
				detalle.AgregarDetalle(Utilidades.TOINT(dr.Cells[0].Text), 0,0,
		     	dr.Cells[1].Text, Convert.ToDecimal(dr.Cells[2].Text), Convert.ToDecimal(dr.Cells[3].Text)
				   );
				cantidad++;
			
			}

			
				if (clientec != null)
				{

				facturaG = new Entidades.Facturas(0, Convert.ToDateTime(FechaTextBox.Text),
					Convert.ToDecimal(SubtotalTextBox.Text), 0.18m,
					Convert.ToDecimal(TotalTextBox.Text), Utilidades.TOINT(ClienteIdTextBox.Text), NombreTextBox.Text);
						
				}
				else
				{
					Utilidades.ShowToastr(this, "Error cliente vacio", "error");
				}
			


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
            artig = BLL.ProductosBLL.Buscar(p => p.ProductoId == id);

            int id2 = 0;
            if (facturaG != null)
            {
                id2 = facturaG.FacturaId;

            }



            if (Utilidades.TOINT(CantidadTextBox.Text) > artig.Cantidad)
            {

                Utilidades.ShowToastr(this, "Cantidad exece existencia", "info");
               // CantidadTextBox.Text = "";
            }
            else
            {
                bool agregado = false;

                foreach (GridViewRow producto in FacturaGridView.Rows)
                {


                    int prueba = Utilidades.TOINT(producto.Cells[0].Text);
                    if (artig.ProductoId == Utilidades.TOINT(producto.Cells[0].Text))
                    {
                        agregado = true;
                       

                        break;

                    }
                }
                if (agregado)
                {
                  
                    Utilidades.ShowToastr(this, " Articulo ya esta en factura -Selecione otro","Error" , "info");

                }
                else
                {
					

					DataTable dt = (DataTable)ViewState["Detalle"];
                    dt.Rows.Add(ProductoIdTextBox.Text, artig.Descripcion.Trim(),  artig.Precio, CantidadTextBox.Text.Trim() );
                    ViewState["Detalle"] = dt;
                    this.BindGrid();
                   // CalcularMonto();
                    CantidadTextBox.Text = "";


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
				

				

						if (BLL.FacturasBLL.Guardar(facturaG, detallef.Detalle))
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
          //  FacturaIdTextBox.Text = "";

        }
        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(FacturaIdTextBox.Text))
            {
                Utilidades.ShowToastr(this, "ID Vacio", "Resultados", "error");

            }
            else
            {
                int id = Utilidades.TOINT(FacturaIdTextBox.Text);

                facturaG = BLL.FacturasBLL.Buscar(f => f.FacturaId == id);
                if (facturaG != null)
                {

                    Limpiar();
                
                    listaRelaciones = BLL.FacturasProductosBLL.GetList(A => A.FacturaId == facturaG.FacturaId);

                    if (facturaG != null)
                    {


                        if (listaRelaciones.Count == 0)
                        {
                            Utilidades.ShowToastr(this, "No se ha registrado Articulos con este ID", "Resultados", "error");


                        }
                        else
                        {

                           

                            foreach (var relacion in listaRelaciones)
                            {
                                listadoArticulos.Add(BLL.ProductosBLL.Buscar(A => A.ProductoId == relacion.ProductoId));
                            }

                            foreach (var articulo in listadoArticulos)
                            {
                                articulo.ProductoId = BLL.ProductosBLL.Buscar(A => A.ProductoId == articulo.ProductoId).ProductoId;
                            }

                            LlenarRegistro(listaRelaciones);


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

                    facturaG = BLL.FacturasBLL.Buscar(f => f.FacturaId == id);



                    if (facturaG != null)
                    {


                        if (BLL.FacturasBLL.EliminarRelacion(facturaG))
                        {

                        Limpiar();

                            facturaG = new Entidades.Facturas();
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
    }
}