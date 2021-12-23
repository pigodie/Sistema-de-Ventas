using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using layerEntidades;

namespace layerDatos
{
    public class d_cliente
    {
        e_usuario objEnUser = new e_usuario();
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex1"].ConnectionString);

        public DataTable filtrarCliente(e_cliente cliente)
        {

            SqlCommand cmd = new SqlCommand("buscarCliente1", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();
            cmd.Parameters.AddWithValue("@ruccliente", cliente.Ruc);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            cn.Close();
        }

        public DataTable mostrarClientes()
        {

            SqlCommand cmd = new SqlCommand("listarCliente1", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            cn.Close();
        }
        public DataTable listarDistrito() {
            SqlCommand cmd = new SqlCommand("listarDistrito", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            cn.Close();

        }
        public void agregarCliente(e_cliente cliente)
        {
            SqlCommand cmd = new SqlCommand("agregarCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();
            cmd.Parameters.AddWithValue("@rucCliente", cliente.Ruc);
            cmd.Parameters.AddWithValue("@empresaCliente", cliente.Empresa);
            cmd.Parameters.AddWithValue("@correoCliente", cliente.Correo);
            cmd.Parameters.AddWithValue("@webCliente", cliente.Pagina);
            cmd.Parameters.AddWithValue("@direccionCliente", cliente.direccion);
            cmd.Parameters.AddWithValue("@codigoDistrito", cliente.Distrito);
            cmd.Parameters.AddWithValue("@representanteCliente", cliente.Representante);
            cmd.Parameters.AddWithValue("@celularCliente", cliente.Celular);

            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void editarCliente(e_cliente cliente)
        {
            SqlCommand cmd = new SqlCommand("modificarCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();
            cmd.Parameters.AddWithValue("@rucCliente", cliente.Ruc);
            cmd.Parameters.AddWithValue("@empresaCliente", cliente.Empresa);
            cmd.Parameters.AddWithValue("@correoCliente", cliente.Correo);
            cmd.Parameters.AddWithValue("@webCliente", cliente.Pagina);
            cmd.Parameters.AddWithValue("@direccionCliente", cliente.direccion);
            cmd.Parameters.AddWithValue("@codigoDistrito", cliente.Distrito);
            cmd.Parameters.AddWithValue("@representanteCliente", cliente.Representante);
            cmd.Parameters.AddWithValue("@celularCliente", cliente.Celular);
            cmd.Parameters.AddWithValue("@idCliente", cliente.Id);

            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void eliminarCliente(e_cliente cliente)
        {
            SqlCommand cmd = new SqlCommand("eliminarcliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();
            cmd.Parameters.AddWithValue("@idCliente", cliente.Id);

            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
