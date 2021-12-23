using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using layerEntidades;
using layerDatos;
using System.Data;

namespace layerNegocio
{
    public class n_reporteFac
    {

        d_reporteFac objDataFac = new d_reporteFac();
        public DataTable FiltarFactura(e_reporteFac rf,int accion) {
            return objDataFac.ReporteFacturas(rf, accion);
        }
    }
}
