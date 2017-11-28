using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace LibreriaCamilo
{
    public static class Utilidades
    {
        public static int TOINT(string numero)
        {
            int retorno = 0;
            int.TryParse(numero, out retorno);
            return retorno;
        }

		public static void ShowToastr(this Page page, string message, string title, string type = "info")
		{
			page.ClientScript.RegisterStartupScript(page.GetType(), "toastr_message",
				  String.Format("toastr.{0}('{1}', '{2}');", type.ToLower(), message, title), addScriptTags: true);
		}

	}
}
