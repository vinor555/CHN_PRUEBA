using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Windows;

namespace chn_prueba
{
    public class Operaciones
    {
        String conexion = "data source=DESKTOP-DLHFKO2;Initial Catalog=CHN_PRUEBA;Integrated Security=True";
        SqlConnection con;

        public void MsgBox(String ex, Page pg, Object obj)
        {
            string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }

        public DataSet CrearCliente(string CUI, string Nombre, string Apellido, string Direccion, string Telefono)
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("CREAR_CLIENTE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CUI", CUI);
                cmd.Parameters.AddWithValue("@NOMBRE", Nombre);
                cmd.Parameters.AddWithValue("@APELLIDO", Apellido);
                cmd.Parameters.AddWithValue("@DIRECCION", Direccion);
                cmd.Parameters.AddWithValue("@TELEFONO", Telefono);
                cmd.Connection = con;
                SqlDataAdapter SqlData = new SqlDataAdapter(cmd);
                SqlData.Fill(ds);
                con.Close();
            }
            catch (Exception ex)
            {
                //MsgBox("Error, el cliente no se pudo crear ",, this);
            }
            return ds;
        }

        public DataSet CrearChequera(string numero_cuenta, int id_cliente, int id_cuenta)
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("CREAR_CHEQUERA", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NUMERO_CHEQUERA", numero_cuenta);
                cmd.Parameters.AddWithValue("@ID_CLIENTE", id_cliente);
                cmd.Parameters.AddWithValue("@ID_CUENTA", id_cuenta);
                SqlDataAdapter SqlData = new SqlDataAdapter(cmd);
                SqlData.Fill(ds);
                con.Close();
            }
            catch (Exception ex)
            {
                //MsgBox("Error, el cliente no se pudo crear ",, this);
            }
            return ds;
        }

        public ICollection Obter_Cliente()
        {
            DataTable dt = new DataTable();
            DataView dv = new DataView();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("OBTENER_CLIENTE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                SqlDataAdapter datapter = new SqlDataAdapter(cmd);
                datapter.Fill(dt);
                
                dv = new DataView(dt);
                
                con.Close();
                return dv;

            }
            catch (Exception)
            {
                //MessageBox.Show("Error al cargar los roles de usuario");
            }
            return dv;
        }

        public ICollection Obtener_Cui()
        {
            DataTable dt = new DataTable();
            DataView dv = new DataView();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("OBTENER_CUI", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                SqlDataAdapter datapter = new SqlDataAdapter(cmd);
                datapter.Fill(dt);

                dv = new DataView(dt);

                con.Close();
                return dv;

            }
            catch (Exception)
            {
                //MessageBox.Show("Error al cargar los roles de usuario");
            }
            return dv;
        }

        public ICollection Obter_cuenta()
        {
            DataTable dt = new DataTable();
            DataView dv = new DataView();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("OBTENER_CUENTA", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                SqlDataAdapter datapter = new SqlDataAdapter(cmd);
                datapter.Fill(dt);

                dv = new DataView(dt);

                con.Close();
                return dv;

            }
            catch (Exception)
            {
                //MessageBox.Show("Error al cargar los roles de usuario");
            }
            return dv;
        }

        public ICollection cuenta_cliente(int id_cliente)
        {
            DataTable dt = new DataTable();
            DataView dv = new DataView();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("CUENTA_CLIENTE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_CLIENTE", id_cliente);
                cmd.Connection = con;
                SqlDataAdapter datapter = new SqlDataAdapter(cmd);
                datapter.Fill(dt);

                dv = new DataView(dt);

                con.Close();
                return dv;

            }
            catch (Exception)
            {
                //MessageBox.Show("Error al cargar los roles de usuario");
            }
            return dv;
        }


        public DataSet cliente_busqueda(string idcliente)
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("CLIENTE_BUSQUEDA", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CUI", idcliente);
                cmd.Connection = con;
                SqlDataAdapter SqlData = new SqlDataAdapter(cmd);
                SqlData.Fill(ds);
                con.Close();
            }
            catch (Exception ex)
            {
               
            }
            return ds;
        }

        public DataSet cuenta_busqueda(int numerocuenta)
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("CUENTA_BUSQUEDA", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_CUENTA", numerocuenta);
                cmd.Connection = con;
                SqlDataAdapter SqlData = new SqlDataAdapter(cmd);
                SqlData.Fill(ds);
                con.Close();
            }
            catch (Exception ex)
            {

            }
            return ds;
        }

        public ICollection Obter_tipo_cuenta()
        {
            DataTable dt = new DataTable();
            DataView dv = new DataView();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("OBTENER_TIPO_CUENTA", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                SqlDataAdapter datapter = new SqlDataAdapter(cmd);
                datapter.Fill(dt);

                dv = new DataView(dt);

                con.Close();
                return dv;

            }
            catch (Exception)
            {
                //MessageBox.Show("Error al cargar los roles de usuario");
            }
            return dv;
        }

        public ICollection Obter_chequera()
        {
            DataTable dt = new DataTable();
            DataView dv = new DataView();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("OBTENER_CHEQUERA", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                SqlDataAdapter datapter = new SqlDataAdapter(cmd);
                datapter.Fill(dt);

                dv = new DataView(dt);

                con.Close();
                return dv;

            }
            catch (Exception)
            {
                //MessageBox.Show("Error al cargar los roles de usuario");
            }
            return dv;
        }

        public DataSet crear_cuenta(string numero_cuenta, decimal saldo, int id_cliente, int id_tipo_cuenta)
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("CREAR_CUENTA", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NUMERO_CUENTA", numero_cuenta);
                cmd.Parameters.AddWithValue("@SALDO", saldo);
                cmd.Parameters.AddWithValue("@ID_CLIENTE", id_cliente);
                cmd.Parameters.AddWithValue("@ID_TIPO_CUENTA", id_tipo_cuenta);
                cmd.Connection = con;
                SqlDataAdapter datapter = new SqlDataAdapter(cmd);
                datapter.Fill(ds);
                con.Close();
            }
            catch (Exception e)
            {
               // MessageBox.Show("Error, el usuario no se ha podido crear");
            }

            return ds;
        }

        public DataSet crear_cheque(string inicio, string fin, int id_chequera)
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("CREAR_CHEQUE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@INICIO", inicio);
                cmd.Parameters.AddWithValue("@FIN", fin);
                cmd.Parameters.AddWithValue("@ID_CHEQUERA", id_chequera);
                cmd.Connection = con;
                SqlDataAdapter datapter = new SqlDataAdapter(cmd);
                datapter.Fill(ds);
                con.Close();
            }
            catch (Exception e)
            {
                // MessageBox.Show("Error, el usuario no se ha podido crear");
            }

            return ds;
        }

        public DataSet Modificarcliente(string cui, string nombre, string apellido, string direccion, string telefono)
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("MODIFICAR_CLIENTE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CUI", cui);
                cmd.Parameters.AddWithValue("@NOMBRE", nombre);
                cmd.Parameters.AddWithValue("@APELLIDO", apellido);
                cmd.Parameters.AddWithValue("@DIRECCION", direccion);
                cmd.Parameters.AddWithValue("@TELEFONO", telefono);
                cmd.Connection = con;
                SqlDataAdapter SqlData = new SqlDataAdapter(cmd);
                SqlData.Fill(ds);
                con.Close();

            }
            catch (Exception ex)
            {
                
            }

            return ds;
        }

        public DataSet modificar_cuenta(int id_cuenta, string numero_cuenta, decimal saldo, int id_cliente, int id_tipo_cuenta)
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("MODIFICAR_CUENTA", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_CUENTA", id_cuenta);
                cmd.Parameters.AddWithValue("@NUMERO_CUENTA", numero_cuenta);
                cmd.Parameters.AddWithValue("@SALDO", saldo);
                cmd.Parameters.AddWithValue("@ID_CLIENTE", id_cliente);
                cmd.Parameters.AddWithValue("@ID_TIPO", id_tipo_cuenta);
                cmd.Connection = con;
                SqlDataAdapter datapter = new SqlDataAdapter(cmd);
                datapter.Fill(ds);
                con.Close();
            }
            catch (Exception e)
            {
                // MessageBox.Show("Error, el usuario no se ha podido crear");
            }

            return ds;
        }

        public DataSet Datos()
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("MOSTRAR_DATOS", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                SqlDataAdapter SqlData = new SqlDataAdapter(cmd);
                SqlData.Fill(ds);
                con.Close();
            }
            catch (Exception ex)
            {

            }
            return ds;
        }



    }
}