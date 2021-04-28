using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chn_prueba
{
    public partial class Cuentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnccrear_Click(object sender, EventArgs e)
        {
            Response.Redirect("Crear_CUenta.aspx");
        }

        protected void btnmodificar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Modificar_Cuenta.aspx");
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