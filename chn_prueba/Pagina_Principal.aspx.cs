using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chn_prueba
{
    public partial class Pagina_Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncrearchequera_Click(object sender, EventArgs e)
        {
            Response.Redirect("Chequeras.aspx");
        }

        protected void btnclientes_Click(object sender, EventArgs e)
        {
            Response.Redirect("Clientes.aspx");
        }

        protected void btncuentas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cuentas.aspx");
        }

        protected void btncheques_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cheques.aspx");
        }

        protected void btndatos_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mostrar_Datos.aspx");
        }
    }
}