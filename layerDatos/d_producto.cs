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
    public class d_producto
    {
        e_usuario objEnUser = new e_usuario();
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex1"].ConnectionString);

        public DataTable listarCategoria()
        {
            SqlCommand cmd = new SqlCommand("listarCategoriatb", cn);
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

        public DataTable mostrarProducto()
        {

            SqlCommand cmd = new SqlCommand("listarProducto1", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();
            cmd.Parameters.AddWithValue("@metodo", "todo");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            cn.Close();
        }

        public DataTable filtrarProducto(e_producto producto)
        {

            SqlCommand cmd = new SqlCommand("filtrarProducto1", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();
            cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            cn.Close();
        }

        public DataTable filtrarProductoCodigo(e_producto producto)
        {

            SqlCommand cmd = new SqlCommand("filtrarProducto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();
            cmd.Parameters.AddWithValue("@codigo", producto.Codigo);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            cn.Close();
        }
        public void agregarProducto(e_producto producto)
        {
            SqlCommand cmd = new SqlCommand("agregarProducto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();
            cmd.Parameters.AddWithValue("@codigoProducto", producto.Codigo);
            cmd.Parameters.AddWithValue("@nombreProducto", producto.Nombre);
            cmd.Parameters.AddWithValue("@StockProducto", producto.Stock);
            cmd.Parameters.AddWithValue("@precioProducto", producto.Precio);
            cmd.Parameters.AddWithValue("@idCategoria", producto.categoria);
         
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void modificarProducto(e_producto producto)
        {
            SqlCommand cmd = new SqlCommand("modificarProducto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();
            cmd.Parameters.AddWithValue("@codigoProducto", producto.Codigo);
            cmd.Parameters.AddWithValue("@nombreProducto", producto.Nombre);
            cmd.Parameters.AddWithValue("@StockProducto", producto.Stock);
            cmd.Parameters.AddWithValue("@precioProducto", producto.Precio);
            cmd.Parameters.AddWithValue("@idCategoria", producto.categoria);
            cmd.Parameters.AddWithValue("@idproducto", producto.Id);

            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void eliminarProducto(e_producto producto)
        {
            SqlCommand cmd = new SqlCommand("eliminarProducto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();
            cmd.Parameters.AddWithValue("idProducto", producto.Id);

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void actualizarStock(String cant, String id)
        {
            SqlCommand cmd = new SqlCommand("Actualizar_stock1", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();
            cmd.Parameters.AddWithValue("@idProducto", id);
            cmd.Parameters.AddWithValue("@cantidadVenta", cant);
   

            cmd.ExecuteNonQuery();
            cn.Close();
        }




    }
}
