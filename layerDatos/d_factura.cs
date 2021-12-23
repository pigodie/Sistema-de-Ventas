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
    public class d_factura
    {
       // e_factura objEnFac = new e_factura();
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex1"].ConnectionString);

        public void agregarFactura(e_factura factura, e_producto producto)
        {
            SqlCommand cmd = new SqlCommand("facturar5", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();
            cmd.Parameters.AddWithValue("@idCliente", factura.idCliente);
            cmd.Parameters.AddWithValue("@idUsuario", factura.idUsuario);
            cmd.Parameters.AddWithValue("@precio", factura.subTotal);
            cmd.Parameters.AddWithValue("@idProducto", producto.Id);
            cmd.Parameters.AddWithValue("@cantidad", factura.cantidad);

            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public DataTable listarFactura()
        {
            SqlCommand cmd = new SqlCommand("listarFactura2", cn);
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
    }
}
