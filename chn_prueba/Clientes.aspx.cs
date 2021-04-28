using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chn_prueba
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnccrear_Click(object sender, EventArgs e)
        {
            Response.Redirect("Crear_Cliente.aspx");
        }

        protected void btnmodificar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Modificar_Cliente.aspx");
        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {

        }

        protected void btninicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina_Principal.aspx");
        }
    }
}