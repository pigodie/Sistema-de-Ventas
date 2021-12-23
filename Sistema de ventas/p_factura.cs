using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using layerEntidades;
using layerNegocio;
namespace Sistema_de_ventas
{
    public partial class p_factura : Form
    {
        Validar validar = new Validar();
        n_cliente objCliente = new n_cliente();
        e_cliente objCliEntidad = new e_cliente();
        n_producto objNePro = new n_producto();
        e_producto objEnPro = new e_producto();
        n_usuario objNeUser = new n_usuario();
        e_usuario objEnUser = new e_usuario();

        n_factura objNeFac = new n_factura();
        e_factura objEnFac = new e_factura();

        String idProducto = "";
        String Cantidad = "";
        String idUsuario = "";
        String idCliente = "";

        string[] idpro = new string[100];
        string[] cant = new string[100];
        int cont = 0;

        public p_factura()
        {
            InitializeComponent();
        }

        void reordenarString(int index) {
            idpro[index] = "";
            cant[index] = "";

        }

        void rellenarString() {
            idpro[cont] = idProducto;
            cant[cont] = txtCant.Text;
            cont++;
        }
        void actualizarStock() {
            for (int i = 0; i < cont; i++)
            {
                objNePro.actualizarStock(idpro[i], cant[i]);
            }
        }

        void autocompletarCliente()
        {

            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            DataTable dt = objCliente.mostrarClientes();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //txtBusqueda.Text = i.ToString();
                lista.Add(dt.Rows[i]["ruc"].ToString());
            }
            txtBusquedaRuc.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBusquedaRuc.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBusquedaRuc.AutoCompleteCustomSource = lista;
        }

        void autocompletarUsuario()
        {

            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            DataTable dt = objNeUser.mostrarUser();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //txtBusqueda.Text = i.ToString();
                lista.Add(dt.Rows[i]["dni"].ToString());
            }
            txtBusquedaUser.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBusquedaUser.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBusquedaUser.AutoCompleteCustomSource = lista;
        }


        void autocompletarProducto()
        {

            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            DataTable dt = objNePro.listarProducto();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lista.Add(dt.Rows[i]["nombre"].ToString());
            }
            txtBusquedaPro.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBusquedaPro.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBusquedaPro.AutoCompleteCustomSource = lista;
        }
        void filtrarCliente()
        {
            objCliEntidad.Ruc = txtBusquedaRuc.Text;
            DataTable dt = objCliente.filtrarCliente(objCliEntidad);
            if (dt.Rows.Count>0)
            {
                lblEmpresa.Text = dt.Rows[0]["Empresa"].ToString();
                lblDir.Text = dt.Rows[0]["direccion"].ToString();
                idCliente = dt.Rows[0]["id"].ToString();
            }
            else 
            {
             
            }
        }
        void filtrarProducto()
        {
            objEnPro.Nombre = txtBusquedaPro.Text;
            DataTable dt = objNePro.filtarProducto(objEnPro);
            if (dt.Rows.Count>0)
            {
                lblCodigo.Text = dt.Rows[0]["codigo"].ToString();
                lblPrecio.Text = dt.Rows[0]["precio"].ToString();
                idProducto = dt.Rows[0]["id"].ToString();
            }
        }
        void filtrarUsuario()
        {
            objEnUser.dni = txtBusquedaUser.Text;
            DataTable dt = objNeUser.filtrarUsuario(objEnUser);
            if (dt.Rows.Count > 0)
            {
                lblVendedor.Text = dt.Rows[0]["nombre"].ToString();
                String ape = dt.Rows[0]["apellido"].ToString();
                lblVendedor.Text = lblVendedor.Text + " " + ape;
                idUsuario = dt.Rows[0]["id"].ToString();
            }
        }
        void sumarColumna() {
           Double suma = 0;
            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                suma += Convert.ToDouble(row.Cells["SUB_TOTAL"].Value) ;

            }
            lblSub.Text = suma.ToString();
            Double igv = suma * 0.18;
            lblIgv.Text = igv.ToString();
            double total = suma + igv;
            lblTotal.Text = total.ToString();
            
        }

        void setear() {
            objEnFac.idCliente = idCliente;
            objEnFac.idUsuario = idUsuario;
            objEnFac.subTotal = lblSub.Text;
            objEnFac.cantidad = "";
            objEnPro.Id = "";

            
        }
        void guardarFactura() {
            setear();
            objNeFac.agregarFactura(objEnFac,objEnPro);
        }
        void botones(bool agregar, bool guardar,bool nuevo)
        {
            btnAgregarItem.Enabled = agregar;
            btnAgregarFac.Enabled = guardar;
            btnNuevo.Enabled = nuevo;
           
   
            if (btnAgregarFac.Enabled == false) btnAgregarFac.BackColor = Color.FromArgb(30, 38, 70);
            else btnAgregarFac.BackColor = Color.FromArgb(17, 97, 238);
            if (btnAgregarItem.Enabled == false) btnAgregarItem.BackColor = Color.FromArgb(30, 38, 70);
            else btnAgregarItem.BackColor = Color.FromArgb(17, 97, 238);
            if (btnNuevo.Enabled == false) btnNuevo.BackColor = Color.FromArgb(30, 38, 70);
            else btnNuevo.BackColor = Color.FromArgb(17, 97, 238);
        }
        void validarAgregar() {
            if (txtBusquedaPro.TextLength>0 && txtCant.TextLength>0 && txtBusquedaUser.TextLength>0 && txtBusquedaRuc.TextLength>0)
            {
                btnAgregarItem.Enabled = true;
            }
            else
            {
                btnAgregarItem.Enabled = false;
            }
        }
        void limpiar() {
            validar.limpiar(gbCli);
            validar.limpiar(gbPro);
            validar.limpiar(gbVendedor);
            lblDir.Text = "";
            lblEmpresa.Text = "";
            lblSub.Text = "";
            lblIgv.Text = "";
            lblTotal.Text = "";
            lblVendedor.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void p_factura_Load(object sender, EventArgs e)
        {
            botones(false, false, true);
            limpiar();
            dgvLista.Columns[5].Width = 60;
            dgvLista.Columns[1].Width = 95;
            autocompletarCliente();
            autocompletarProducto();
            autocompletarUsuario();
        }

        private void txtBusquedaRuc_TextChanged(object sender, EventArgs e)
        {
            filtrarCliente();
            validarAgregar();
        }

        private void txtBusquedaPro_TextChanged(object sender, EventArgs e)
        {
            filtrarProducto();
            validarAgregar();
        }

        private void txtBusquedaUser_TextChanged(object sender, EventArgs e)
        {
            filtrarUsuario();
            validarAgregar();
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;

            if (dgvLista.CurrentRow.Cells["ELIMINAR"].Selected)
            { dgvLista.Rows.Remove(dgvLista.CurrentRow);
                reordenarString(index);
            }
            
            
        }
        void limpiarPro() {
            txtBusquedaPro.Text = "";
            lblCodigo.Text = "";
            txtCant.Text = "";
            lblPrecio.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            rellenarString();
            double precio = Convert.ToDouble(lblPrecio.Text);
            int cant = int.Parse(txtCant.Text);
            double sub = precio * cant;

            String desc = txtCant.Text + " " + txtBusquedaPro.Text;
            dgvLista.Rows.Add(lblCodigo.Text, desc.ToString(), txtCant.Text, lblPrecio.Text, sub.ToString());
            sumarColumna();
            //validar.limpiar(gbPro);
            botones(false, true, true);
            limpiarPro();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            actualizarStock();
            setear();
            guardarFactura();
            MessageBox.Show("factura guardada con exito");
            
            dgvLista.Rows.Clear();
            p_factura_Load(sender, e);
           
        }

        private void txtBusquedaRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumeros(e,txtBusquedaRuc,txtBusquedaRuc);
        }

        private void txtCant_TextChanged(object sender, EventArgs e)
        {
            validarAgregar();
        }

        private void txtBusquedaUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumeros(e,txtBusquedaUser,txtBusquedaUser);
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumeros(e, txtCant, txtCant);
        }
    }
}
