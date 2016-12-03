using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWeb
{
    public partial class ModificarEliminarCliente : System.Web.UI.Page
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

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            ClienteServ.ServicioClienteClient cliente = new ClienteServ.ServicioClienteClient();

            bool result = cliente.VerificarCliente(DdlRutCliente.SelectedValue);
            if (result)
            {
                var clienteRecuperado = cliente.BuscarCliente(DdlRutCliente.SelectedValue);
                LblId.Text = clienteRecuperado.IdCliente.ToString();
                TxtRut.Text = clienteRecuperado.Rut;
                TxtNombre.Text = clienteRecuperado.NombreCompleto;
                TxtDireccion.Text = clienteRecuperado.Direccion;
            }
            else
            {
                LblMensaje.Text = "Rut no esta registrado.";
                LblMensaje.Visible = true;

            }
        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtRut.Text) || string.IsNullOrWhiteSpace(TxtRut.Text))
            {
                LblMensaje.Text = "Debe ingresar un rut para modificar.";
            }
            else
            {
                ClienteServ.ServicioClienteClient cliente = new ClienteServ.ServicioClienteClient();

                bool result = cliente.VerificarCliente(DdlRutCliente.SelectedValue);

                if (result)
                {
                    decimal idCliente;
                    string rut = TxtRut.Text;
                    string nombre = TxtNombre.Text;
                    string direccion = TxtDireccion.Text;
                    decimal.TryParse(LblId.Text, out idCliente);
                    bool resultMod = cliente.ModificarCliente(idCliente, rut, nombre, direccion);
                    if (resultMod)
                    {
                        LblMensaje.Text = "El cliente fue modificado con éxito.";
                        LblMensaje.Visible = true;
                        LblId.Text = TxtRut.Text = TxtNombre.Text = TxtDireccion.Text = string.Empty;
                    }
                    else
                    {
                        LblMensaje.Text = "Ocurrió un error, cliente no se modificó.";
                        LblMensaje.Visible = true;
                        LblId.Text = TxtRut.Text = TxtNombre.Text = TxtDireccion.Text = string.Empty;
                    }
                }
                else
                {
                    LblMensaje.Text = "El cliente no existe en nuestros registros";
                    LblMensaje.Visible = true;
                    LblId.Text = TxtRut.Text = TxtNombre.Text = TxtDireccion.Text = string.Empty;
                }
            }
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtRut.Text) || string.IsNullOrWhiteSpace(TxtRut.Text))
            {
                LblMensaje.Text = "Debe ingresar un rut para modificar.";
            }
            else
            {
                ClienteServ.ServicioClienteClient cliente = new ClienteServ.ServicioClienteClient();

                bool result = cliente.VerificarCliente(DdlRutCliente.SelectedValue);

                if (result)
                {
                    string rut = TxtRut.Text;

                    BoletaServ.ServicioBoletaClient boleta = new BoletaServ.ServicioBoletaClient();

                    decimal idCliente;
                    decimal.TryParse(LblId.Text, out idCliente);

                    bool ventasClientes = boleta.VerificarBoletaCliente(idCliente);
                    if (ventasClientes)
                    {
                        LblMensaje.Text = "Este cliente tiene ventas asociadas. No puede ser eliminado.";
                    }
                    else
                    {
                        bool resultElim = cliente.EliminarCliente(rut);

                        if (resultElim)
                        {
                            LblMensaje.Text = "El cliente fue eliminado con éxito";
                            LblMensaje.Visible = true;
                            LblId.Text = TxtRut.Text = TxtNombre.Text = TxtDireccion.Text = string.Empty;
                        }
                        else
                        {
                            LblMensaje.Text = "Ocurrió un error. No se eliminó el cliente";
                            LblMensaje.Visible = true;
                            LblId.Text = TxtRut.Text = TxtNombre.Text = TxtDireccion.Text = string.Empty;
                        }
                    }
                    
                }
            }
        }


    }
}