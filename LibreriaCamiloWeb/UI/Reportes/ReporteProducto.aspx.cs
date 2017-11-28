﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaCamiloWeb.UI.Reportes
{
	public partial class ReporteProducto : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			this.ReportViewer1.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
			this.ReportViewer1.Reset();


			this.ReportViewer1.LocalReport.ReportPath = @"C:\Users\Reyman Djc\Desktop\LibreriaCamiloWeb\LibreriaCamiloWeb\UI\Reportes\ProductosReport.rdlc";
			this.ReportViewer1.LocalReport.DataSources.Clear();



			this.ReportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSetProducto", UI.Consultas.cProductos.Lista));

			this.ReportViewer1.LocalReport.Refresh();

		}
	}
}