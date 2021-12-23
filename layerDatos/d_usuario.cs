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
    public class d_usuario

    {
        e_usuario objEnUser = new e_usuario();
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex1"].ConnectionString);

        public DataTable D_Acceso(string Usu, string Pass)
        {

            SqlCommand cmd = new SqlCommand("sp_login1", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cmd.Parameters.AddWithValue("@usuario", Usu);
            cmd.Parameters.AddWithValue("@pass", Pass);
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            
        }
     
        public DataTable mostrarUsuarios() {
           
            SqlCommand cmd = new SqlCommand("listarUsuario1", cn);
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
            
        }
        public DataTable getCargo(String idCargo)
        {

            SqlCommand cmd = new SqlCommand("getCargo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cmd.Parameters.AddWithValue("@idcargo", idCargo);
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            
        }

        public void agregarUsuario(e_usuario usuario)
        {

            
            SqlCommand cmd = new SqlCommand("agregarUsuario1", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();
           
            
            cmd.Parameters.AddWithValue("@dniUsuario", usuario.dni);
            cmd.Parameters.AddWithValue("@nombreUsuario", usuario.nombre);
            cmd.Parameters.AddWithValue("@apellidoUsuario", usuario.apellido);
            cmd.Parameters.AddWithValue("@cargo", usuario.cargo);
            cmd.Parameters.AddWithValue("@usuarioUsuario", usuario.usuario);
            cmd.Parameters.AddWithValue("@claveUsuario", usuario.pass);

            cmd.ExecuteNonQuery();
            
        }
        
        public void modificarUsuario(e_usuario usuario)
        {

           
            SqlCommand cmd = new SqlCommand("modificarUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();
            cmd.Parameters.AddWithValue("@dniUsuario", usuario.dni);
            cmd.Parameters.AddWithValue("@nombreUsuario", usuario.nombre);
            cmd.Parameters.AddWithValue("@apellidoUsuario", usuario.apellido);
            cmd.Parameters.AddWithValue("@cargo", usuario.cargo);
            cmd.Parameters.AddWithValue("@claveUsuario", usuario.pass);
            cmd.Parameters.AddWithValue("@idUsuario", usuario.id);


            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void eliminarUsuario(e_usuario usuario)
        { 
            SqlCommand cmd = new SqlCommand("eliminarUsuario1", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();
            cmd.Parameters.AddWithValue("@idUsuario", usuario.id);
           

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public DataTable filtrarUsuario(e_usuario usuario)
        {

            SqlCommand cmd = new SqlCommand("filtrarUsuario1", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dniUsuario", usuario.dni);
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            
        }





    }
}
