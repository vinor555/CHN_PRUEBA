using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chn_prueba
{
    public partial class Modificar_Cuenta : System.Web.UI.Page
    {
        Operaciones OpBD = new Operaciones();
        protected void Page_Load(object sender, EventArgs e)
        {
            LLenar_Cuenta();
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

        public void LLenar_Cuenta()
        {
            if (!IsPostBack)
            {
                txtbuscarcuenta.DataSource = OpBD.Obter_cuenta();
                txtbuscarcuenta.DataTextField = "NUMERO_CUENTA";
                txtbuscarcuenta.DataValueField = "ID_CUENTA";
                txtbuscarcuenta.DataBind();
                txtbuscarcuenta.SelectedIndex = 0;

            }
        }

        public void modificarCuenta()
        {
            DataSet ds = new DataSet();
            ds = OpBD.modificar_cuenta(Convert.ToInt32(txtbuscarcuenta.Text),txtbuscarcuenta.SelectedItem.Text, Convert.ToDecimal(txtsaldo.Text), Convert.ToInt32(cbb_cliente.SelectedItem.Value), Convert.ToInt32(cbb_tipo.SelectedItem.Value));
            OpBD.MsgBox("Cuenta creada con exito", this.Page, this);
            limpiar();
        }

        public void limpiar()
        {
           
            txtsaldo.Text = "";
        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = OpBD.cuenta_busqueda(Convert.ToInt32(txtbuscarcuenta.SelectedValue));

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtbuscarcuenta.Enabled = false;
                TextBox1.Text = Convert.ToString(ds.Tables[0].Rows[0]["NUMERO_CUENTA"]);
                txtsaldo.Text = Convert.ToString(ds.Tables[0].Rows[0]["SALDO"]);
                cbb_cliente.SelectedValue = Convert.ToString(ds.Tables[0].Rows[0]["ID_CLIENTE"]);
                cbb_tipo.SelectedValue = Convert.ToString(ds.Tables[0].Rows[0]["ID_TIPO"]);


            }
        }

        protected void btninicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina_Principal.aspx");
        }

        protected void cbb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btncrear_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = OpBD.cuenta_busqueda(Convert.ToInt32(txtbuscarcuenta.SelectedValue));

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtbuscarcuenta.Enabled = false;
                TextBox1.Text = Convert.ToString(ds.Tables[0].Rows[0]["NUMERO_CUENTA"]);
                txtsaldo.Text = Convert.ToString(ds.Tables[0].Rows[0]["SALDO"]);
                cbb_cliente.SelectedValue = Convert.ToString(ds.Tables[0].Rows[0]["ID_CLIENTE"]);
                cbb_tipo.SelectedValue = Convert.ToString(ds.Tables[0].Rows[0]["ID_TIPO"]);


            }
        }

        protected void btnmodificarcuenta_Click(object sender, EventArgs e)
        {
            modificarCuenta();
        }

        protected void cbb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txtbuscarcuenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void cbb_tipo_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }
}