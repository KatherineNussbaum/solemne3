using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWeb
{
    public partial class Productos : System.Web.UI.Page
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
    }
}