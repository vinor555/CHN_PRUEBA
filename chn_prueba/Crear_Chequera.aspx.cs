using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chn_prueba
{
    public partial class Crear_Chequera : System.Web.UI.Page
    {
        Operaciones OpBD = new Operaciones();
        int id_cliente;
        int id_cuenta;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LLenar_Cliente();
            }
        }

        
        private void LLenar_Cliente()
        {
            if (!IsPostBack)
            {
                cbb_cliente.DataSource = OpBD.Obter_Cliente();
                cbb_cliente.DataTextField = "NOMBRE";
                cbb_cliente.DataValueField = "ID_CLIENTE";
                cbb_cliente.DataBind();

                if (cbb_cliente.Items.Count != 0)
                    {
                        int idcliente = Convert.ToInt32(cbb_cliente.SelectedValue);
                        LLenar_Cuenta(idcliente);
                    }
            }
            else
            {
                cbb_cliente.Items.Clear();
                cbb_cuenta.Items.Clear();
                cbb_cliente.DataSource = null;
                cbb_cliente.DataBind();
            }
        }

        public void LLenar_Cuenta(int cliente)
        {
            
            cbb_cuenta.DataSource = OpBD.cuenta_cliente(cliente);
            cbb_cuenta.DataTextField = "NUMERO_CUENTA";
            cbb_cuenta.DataValueField = "ID_CUENTA";
            cbb_cuenta.DataBind();

        }

            public void CrearChequera()
        {
            DataSet ds = new DataSet();
            ds = OpBD.CrearChequera (txtnumerochequera.Text, Convert.ToInt32(cbb_cliente.SelectedItem.Value), Convert.ToInt32(cbb_cuenta.SelectedItem.Value));
            OpBD.MsgBox("chequera creada con exito", this.Page, this);
            limpiar();
        }

        public void limpiar()
        {
            txtnumerochequera.Text = "";
        }

        protected void btncrearchequera_Click(object sender, EventArgs e)
        {
            CrearChequera();
        }

        protected void cbb_cuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_cuenta = Convert.ToInt32(cbb_cuenta.SelectedItem.Value);
        }

        protected void cbb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_cliente = Convert.ToInt32(cbb_cliente.SelectedItem.Value);
            LLenar_Cuenta(Convert.ToInt32(cbb_cliente.SelectedItem.Value));
           // LLenar_Cuenta(Convert.ToInt32(cbb_cliente.SelectedItem.Value));
        }

        public void obtener_cuenta()
        {
            if (!IsPostBack)
            {
                cbb_cuenta.DataSource = OpBD.cuenta_cliente(Convert.ToInt32(cbb_cliente.SelectedItem.Value));
                cbb_cuenta.DataTextField = "NUMERO_CUENTA";
                //cbb_cuenta.DataValueField = "ID_CLIENTE";
                cbb_cuenta.DataBind();
                cbb_cuenta.SelectedIndex = 0;

            }

            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            obtener_cuenta();
        }

        protected void btninicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina_Principal.aspx");
        }
    }
}