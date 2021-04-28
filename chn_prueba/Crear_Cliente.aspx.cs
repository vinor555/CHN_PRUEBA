using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Windows;

namespace chn_prueba
{
    public partial class Principal : System.Web.UI.Page
    {
        Operaciones OpBD = new Operaciones();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void CrearCliente()
        {
            DataSet ds = new DataSet();
            ds = OpBD.CrearCliente(txtcui.Text, txtnombre.Text, txtapellido.Text,txtdireccion.Text,txttelefono.Text);
            OpBD.MsgBox("Cliente registrado con exito...",this.Page,this);
            limpiar();
        }

        public void limpiar()
        {
            txtcui.Text         = "";
            txtnombre.Text      = "";
            txtapellido.Text    = "";
            txtdireccion.Text   = "";
            txttelefono.Text    = "";
        }

        protected void btncrear_Click(object sender, EventArgs e)
        {
            CrearCliente();
        }

        protected void btninicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina_Principal.aspx");
        }
    }
}