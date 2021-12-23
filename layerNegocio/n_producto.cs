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
    public class n_producto
    {
        d_producto objDataPro = new d_producto();
        public DataTable filtarProducto(e_producto producto) {
            return objDataPro.filtrarProducto(producto);
        }
        public DataTable listarProducto() {
            return objDataPro.mostrarProducto();
        }
        public DataTable listarCategoria() {
            return objDataPro.listarCategoria();
        }
        public DataTable listarProductoCod(e_producto producto) {
            return objDataPro.filtrarProductoCodigo(producto);
        }
        public void eliminarProducto(e_producto producto) {
            objDataPro.eliminarProducto(producto);
        }
        public void agregarProducto(e_producto producto) {
            objDataPro.agregarProducto(producto);
        }
        public void editarProducto(e_producto producto) {
            objDataPro.modificarProducto(producto);
        }
        public void actualizarStock(String id,String cant) {
            objDataPro.actualizarStock(cant, id);
        }
    }
}
