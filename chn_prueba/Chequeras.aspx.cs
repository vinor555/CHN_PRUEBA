using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chn_prueba
{
    public partial class Chequeras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnclientes_Click(object sender, EventArgs e)
        {
            Response.Redirect("Crear_Chequera.aspx");
        }

        protected void btncuentas_Click(object sender, EventArgs e)
        {

        }

        protected void btncrearchequera_Click(object sender, EventArgs e)
        {

        }

        protected void btndatos_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina_Principal.aspx");
        }
    }
}