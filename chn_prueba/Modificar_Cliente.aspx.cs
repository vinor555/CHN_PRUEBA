using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chn_prueba
{
    public partial class Modificar_Usuario : System.Web.UI.Page
    {
        Operaciones OpBD = new Operaciones();
        protected void Page_Load(object sender, EventArgs e)
        {
            LLenar_cui();
        }

        public void LLenar_cui()
        {
            if (!IsPostBack)
            {
                cbb_cui.DataSource = OpBD.Obtener_Cui();
                cbb_cui.DataTextField = "CUI";
                cbb_cui.DataValueField = "CUI";
                cbb_cui.DataBind();
                cbb_cui.SelectedIndex = 0;

            }
        }

        public void modificar_cliente()
        {
            DataSet ds = new DataSet();
            ds = OpBD.Modificarcliente(Convert.ToString(cbb_cui.SelectedItem.Value),txtnombre.Text,txtapellido.Text, txtdireccion.Text, txttelefono.Text);
            OpBD.MsgBox("El cliente ha sido modificado correctamente",this.Page,this);
        }
     

        protected void btnmodificar_Click(object sender, EventArgs e)
        {
            modificar_cliente();
        }

        protected void cbb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    cbb_cui.DataSource = OpBD.Obtener_Cui();
            //    cbb_cui.DataTextField = "CUI";
            //    cbb_cui.DataValueField = "CUI";
            //    cbb_cui.DataBind();
            //    cbb_cui.SelectedIndex = 0;


            //}

            
            DataSet ds = new DataSet();
            ds = OpBD.cliente_busqueda(Convert.ToString(cbb_cui.SelectedValue));

            if (ds.Tables[0].Rows.Count > 0)
            {
                cbb_cui.Enabled = false;
                txtcui.Text = Convert.ToString(ds.Tables[0].Rows[0]["CUI"]);
                txtnombre.Text = Convert.ToString(ds.Tables[0].Rows[0]["NOMBRE"]);
                txtapellido.Text = Convert.ToString(ds.Tables[0].Rows[0]["APELLIDO"]);
                txtdireccion.Text = Convert.ToString(ds.Tables[0].Rows[0]["DIRECCION"]);
                txttelefono.Text = Convert.ToString(ds.Tables[0].Rows[0]["TELEFONO"]);


            }
        }

        protected void btninicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina_Principal.aspx");
        }
    }
}