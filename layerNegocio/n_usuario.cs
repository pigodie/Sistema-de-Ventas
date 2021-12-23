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
   public class n_usuario
    {
        d_usuario objDUser = new d_usuario();

        public DataTable getCargo(String idcargo) {
            return objDUser.getCargo(idcargo);
        }

        public DataTable n_acceso(String usu, String pass) {
            return objDUser.D_Acceso(usu, pass);
        }

        public DataTable mostrarUser() {
            return objDUser.mostrarUsuarios();
        }
        public void agregarUsuario(e_usuario usuario) {
            objDUser.agregarUsuario(usuario);
        }
        public void modificarUsuario(e_usuario usuario) {
            objDUser.modificarUsuario(usuario);
        }
        public void eliminarUsuario(e_usuario usuario) {
            objDUser.eliminarUsuario(usuario);
        }
        public DataTable filtrarUsuario(e_usuario usuario) {
            return objDUser.filtrarUsuario(usuario);
        }
    }
}
