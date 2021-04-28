using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chn_prueba
{
    public partial class Crear_Cheque : System.Web.UI.Page
    {
        Operaciones OpBD = new Operaciones();
        protected void Page_Load(object sender, EventArgs e)
        {
            LLenar_Chequera();
        }

        public void LLenar_Chequera()
        {
            if (!IsPostBack)
            {
                cbb_cheque.DataSource = OpBD.Obter_chequera();
                cbb_cheque.DataTextField = "NUMERO_CHEQUERA";
                cbb_cheque.DataValueField = "ID_CHEQUERA";
                cbb_cheque.DataBind();
                cbb_cheque.SelectedIndex = 0;

            }
        }

        protected void cbb_chequera_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_chequera = Convert.ToInt32(cbb_cheque.SelectedItem.Value);
        }

        public void CrearCheque()
        {
            DataSet ds = new DataSet();
            ds = OpBD.crear_cheque(txtinicio.Text,txtfin.Text, Convert.ToInt32(cbb_cheque.SelectedItem.Value));
            OpBD.MsgBox("Cheques creada con exito", this.Page, this);
            txtinicio.Text="";
            txtfin.Text = "";
        }

        protected void btncrearchequera_Click(object sender, EventArgs e)
        {
            CrearCheque();
        }

        protected void btninicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina_Principal.aspx");
        }
    }
}