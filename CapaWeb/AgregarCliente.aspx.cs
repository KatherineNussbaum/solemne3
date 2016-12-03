using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWeb
{
    public partial class AgregarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("Index.aspx");
            }
            string usuario = Session["usuario"].ToString();
            LblUsuario.Text = usuario;
            LblUsuario.Visible = true;

        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            LblMensaje.Visible = false;
            string rut = TxtRut.Text;
            string nombre = TxtNombre.Text;
            string direccion = TxtDireccion.Text;

            ClienteServ.ServicioClienteClient cliente = new ClienteServ.ServicioClienteClient();
            if (cliente.VerificarCliente(rut))
            {
                LblMensaje.Text = "Rut ya se encuentra ingresado.";
                LblMensaje.Visible = true;
            }
            else
            {
                bool result = cliente.AgregarCliente(rut, nombre, direccion);
                if (result)
                {
                    LblMensaje.Text = "Cliente agregado con éxito.";
                    LblMensaje.Visible = true;
                    TxtRut.Text = TxtNombre.Text = TxtDireccion.Text = string.Empty;
                }
                else
                {
                    LblMensaje.Text = "Ocurrió un error";
                    LblMensaje.Visible = true;
                }
            }
        }
    }
}