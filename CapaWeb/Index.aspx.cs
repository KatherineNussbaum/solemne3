using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWeb
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["usuario"] = null;
        }
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            LblMensaje.Visible = false;
            LoginVendedorServ.ServicioLoginVendedorClient loginVendedor = new LoginVendedorServ.ServicioLoginVendedorClient();

            if (!loginVendedor.VerificarLoginVendedor(TxtUsuario.Text))
            {
                LblMensaje.Text = "Usuario ingresado no existe!";
                LblMensaje.Visible = true;
            }
            else
            {
                var usuario = loginVendedor.BuscarLoginVendedor(TxtUsuario.Text);
                if(usuario.Password != TxtPass.Text)
                {
                    LblMensaje.Text = "La contraseña ingresada no corresponde";
                    LblMensaje.Visible = true;
                }
                else
                {
                    if(Session["usuario"] == null)
                    {
                        Session["usuario"] = TxtUsuario.Text;
                        LblMensaje.Text = Session["usuario"].ToString();
                        LblMensaje.Visible = true;

                        Response.Redirect("DatosPersonales.aspx");
                    }
                }
            }
        }
    }
}