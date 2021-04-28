using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chn_prueba
{
    public partial class Crear_Cuenta : System.Web.UI.Page
    {
        Operaciones OpBD = new Operaciones();
        int id_cliente;
        int id_tipo;

        protected void Page_Load(object sender, EventArgs e)
        {
            LLenar_Cliente();
            LLenar_Tipo_Cuenta();
        }

        public void LLenar_Cliente()
        {
            if (!IsPostBack)
            {
                cbb_cliente.DataSource = OpBD.Obter_Cliente(); 
                cbb_cliente.DataTextField = "NOMBRE";
                cbb_cliente.DataValueField = "ID_CLIENTE";
                cbb_cliente.DataBind();
                cbb_cliente.SelectedIndex = 0;

            }
        }

        public void LLenar_Tipo_Cuenta()
        {
            if (!IsPostBack)
            {
                cbb_tipo.DataSource = OpBD.Obter_tipo_cuenta();
                cbb_tipo.DataTextField = "TIPO_CUENTA";
                cbb_tipo.DataValueField = "ID_TIPO";
                cbb_tipo.DataBind();
                cbb_tipo.SelectedIndex = 0;

            }
        }

        public void CrearCuenta()
        {
            DataSet ds = new DataSet();
            ds = OpBD.crear_cuenta(txtnumerocuenta.Text, Convert.ToDecimal(txtsaldo.Text), Convert.ToInt32(cbb_cliente.SelectedItem.Value), id_tipo);
            OpBD.MsgBox("Cuenta creada con exito",this.Page,this);
            limpiar();
        }

        public void limpiar()
        {
            txtnumerocuenta.Text    = "";
            txtsaldo.Text = "";
        }


        protected void btncrear_Click(object sender, EventArgs e)
        {
            CrearCuenta();
        }

        protected void cbb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_tipo = Convert.ToInt32(cbb_tipo.SelectedItem.Value);
        }

        protected void cbb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_cliente = Convert.ToInt32(cbb_cliente.SelectedItem.Value);
        }

        protected void btninicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina_Principal.aspx");
        }
    }
}