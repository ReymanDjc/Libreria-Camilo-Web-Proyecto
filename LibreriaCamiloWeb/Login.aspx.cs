using LibreriaCamilo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaCamiloWeb
{
	public partial class Login : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void LoginButton_Click(object sender, EventArgs e)
		{
            var usuario = new Entidades.Usuarios();
            usuario = BLL.UsuariosBLL.Buscar(b => b.Nombres == TextBox1.Text);
            if (PasswordTextBox.Text != "")
            {            
                if (usuario.Clave == PasswordTextBox.Text)
                {
                    FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, true);
                }
                else
                {
                    Utilidades.ShowToastr(this, "Usuario y/o Contraseña Incorrectas", "ERROR", "info");
                }
                
            }
            else
            {
                Utilidades.ShowToastr(this, "Usuario y/o Contraseña Incorrectas", "ERROR", "info");
            }
        }
	}
}