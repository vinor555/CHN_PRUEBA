using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chn_prueba
{
    public partial class Mostrar_Datos : System.Web.UI.Page
    {
        Operaciones OpBD = new Operaciones();
        protected void Page_Load(object sender, EventArgs e)
        {
            reporte();
        }

        public void reporte()
        {
            DataSet ds = new DataSet();
            ds = OpBD.Datos();
            //dataGridView1.ReadOnly = true;

            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.DataBind();
            //this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView1.EnableHeadersVisualStyles = false;
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine;
            //dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);

        }

        protected void btninicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina_Principal.aspx");
        }
    }
}