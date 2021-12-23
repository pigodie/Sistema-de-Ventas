using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using layerDatos;
using layerEntidades;
namespace layerNegocio
{
    public class n_factura
    {
        d_factura objFacData = new d_factura();
        public void agregarFactura(e_factura factura, e_producto producto) {
            objFacData.agregarFactura(factura, producto);
        }
        public DataTable listarFactura() {
            return objFacData.listarFactura();
        }
    }
}
