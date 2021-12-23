using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using layerDatos;
using layerEntidades;
using System.Data;

namespace layerNegocio
{
    public class n_cliente
    {
        e_cliente objEnCli = new e_cliente();
        d_cliente objDataCli = new d_cliente();
        public DataTable mostrarClientes() {
            return objDataCli.mostrarClientes();
        }

        public DataTable filtrarCliente(e_cliente cliente) {
            return objDataCli.filtrarCliente(cliente);
        }
        public DataTable listarDistrito() {
            return objDataCli.listarDistrito();
        }
        public void agregarCliente(e_cliente cliente) {
            objDataCli.agregarCliente(cliente);
        }
        public void editarCliente(e_cliente cliente) {
            objDataCli.editarCliente(cliente);
        }
        public void eliminarCliente(e_cliente cliente) {
            objDataCli.eliminarCliente(cliente);
        }
        
    }
}
