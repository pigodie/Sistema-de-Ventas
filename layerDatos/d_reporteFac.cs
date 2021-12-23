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
    public class d_reporteFac
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex1"].ConnectionString);

        public DataTable ReporteFacturas(e_reporteFac reporteFac, int accion)
        {
            SqlCommand cmd = new SqlCommand("sp_facturafiltro1", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empresa", reporteFac.empresa);
            cmd.Parameters.AddWithValue("@usuario", reporteFac.usuario);
            cmd.Parameters.AddWithValue("@fec1", reporteFac.fecInicio);
            cmd.Parameters.AddWithValue("@fec2", reporteFac.fecFinal);
            cmd.Parameters.AddWithValue("@accion", accion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
     



    }
}
