using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using layerNegocio;
using layerEntidades;

namespace Sistema_de_ventas
{
    public partial class p_cliente : Form
    {
        Validar validar = new Validar();
        e_cliente objEntCli = new e_cliente();
        n_cliente objNeCli = new n_cliente();
        String id;
        String estado;
        public p_cliente()
        {
            InitializeComponent();
        }

        void limpiar() {
            
        }

        void autocompletar()
        {

            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            DataTable dt = objNeCli.mostrarClientes();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //txtBusqueda.Text = i.ToString();
                lista.Add(dt.Rows[i]["ruc"].ToString());
            }
            txtBusqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBusqueda.AutoCompleteCustomSource = lista;

        }

        void filtrarCliente() {
            objEntCli.Ruc = txtBusqueda.Text;
            DataTable dt = objNeCli.filtrarCliente(objEntCli);
            if (dt.Rows.Count > 0)
            {
                //dgvUsuario.DataSource = null;
               
                dgvCliente.DataSource = dt;
                
            }
            else
            {
                listarCliente();
            }
        }
        void llenarTextbox() { 
            id = dgvCliente.CurrentRow.Cells[0].Value.ToString();
            txtRuc.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
            txtEmpresa.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
            txtCorreo.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
            txtPagina.Text = dgvCliente.CurrentRow.Cells[4].Value.ToString();
            txtDir.Text = dgvCliente.CurrentRow.Cells[5].Value.ToString();
            cbDistrito.Text = dgvCliente.CurrentRow.Cells[6].Value.ToString();
            txtRepre.Text = dgvCliente.CurrentRow.Cells[7].Value.ToString();
            txtCelular.Text = dgvCliente.CurrentRow.Cells[8].Value.ToString();
            
        }

        void setear(String id,String estado) {
            objEntCli.Id = id;
            objEntCli.estado = estado;
            objEntCli.Ruc = txtRuc.Text;
            objEntCli.Pagina = txtPagina.Text;
            objEntCli.Representante = txtRepre.Text;
            objEntCli.Celular = txtCelular.Text;
            objEntCli.Correo = txtCorreo.Text;
            objEntCli.direccion = txtDir.Text;
            int dis;
            
            if (cbDistrito.SelectedItem == null || cbDistrito.SelectedIndex == 0)
            {
                objEntCli.Distrito = "01";

            }
            else
            {
                dis = cbDistrito.SelectedIndex + 1;
                objEntCli.Distrito = dis.ToString();
            }
           
           
            
            objEntCli.Empresa = txtEmpresa.Text;
        }
        void AgregarCliente() {
            objNeCli.agregarCliente(objEntCli);
        }
        void listarCliente()
        {
            DataTable dt = objNeCli.mostrarClientes();
            dgvCliente.DataSource = dt;
            dgvCliente.Columns[0].Visible = false;
     
        }
        void listarDistrito() {
            DataTable dt = objNeCli.listarDistrito();
            cbDistrito.DisplayMember = "nombredistrito";
            cbDistrito.ValueMember = "codigodistrito";
            cbDistrito.DataSource = dt;
        }
        void botones(bool agregar, bool editar, bool nuevo, bool eliminar) {
            btnEditar.Enabled = editar;
            btnEliminar.Enabled = eliminar;
            btnAgregar.Enabled = agregar;
            btnNuevo.Enabled = nuevo;
            if (btnEditar.Enabled == false) btnEditar.BackColor = Color.FromArgb(30, 38, 70);
            else btnEditar.BackColor = Color.FromArgb(17, 97, 238);
            if (btnEliminar.Enabled == false) btnEliminar.BackColor = Color.FromArgb(30, 38, 70);
            else btnEliminar.BackColor = Color.FromArgb(17, 97, 238);
            if (btnAgregar.Enabled == false) btnAgregar.BackColor = Color.FromArgb(30, 38, 70);
            else btnAgregar.BackColor = Color.FromArgb(17, 97, 238);
            if (btnNuevo.Enabled == false) btnNuevo.BackColor = Color.FromArgb(30, 38, 70);
            else btnNuevo.BackColor = Color.FromArgb(17, 97, 238);
        }
        private void p_cliente_Load(object sender, EventArgs e)
        {
            autocompletar();
            listarCliente();
            listarDistrito();
            botones(false, false, true, false);
            validar.limpiar(panelDatos);
            txtRuc.Visible = true;
            lblRuc.Visible = true;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
          
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
          
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            
        }

        private void txtDir_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDir_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
         
            
        }

        private void panelTB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void validarAgregar() {
            if (txtCelular.TextLength>0  && txtCorreo.TextLength>0 && txtDir.TextLength>0 && txtEmpresa.TextLength>0 &&txtPagina.TextLength>0 && txtRepre.TextLength>0 && txtRuc.TextLength>0)
            {
                botones(true, true, true,true);
            }
            else
            {
                botones(false, false, true, false);
            }
        }
        private void dgvCliente_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            llenarTextbox();
            txtRuc.Visible = false;
            lblRuc.Visible = false;
            botones(false, true, true, true);
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            setear("", "");
            objNeCli.agregarCliente(objEntCli);
            p_cliente_Load(sender, e);
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            setear(id,estado);
            objNeCli.editarCliente(objEntCli);
            p_cliente_Load(sender, e);

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            setear(id, estado);
            objNeCli.eliminarCliente(objEntCli);
            p_cliente_Load(sender, e);
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            p_cliente_Load(sender, e);
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            filtrarCliente();
        }

        private void txtEmpresa_TextChanged(object sender, EventArgs e)
        {
            validarAgregar();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            validarAgregar();
        }

        private void txtRuc_TextChanged(object sender, EventArgs e)
        {
            validarAgregar();
        }

        private void txtPagina_TextChanged(object sender, EventArgs e)
        {
            validarAgregar();
        }

        private void txtDir_TextChanged_1(object sender, EventArgs e)
        {
            validarAgregar();
        }

        private void txtRepre_TextChanged(object sender, EventArgs e)
        {
            validarAgregar();
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {
            validarAgregar();
        }

        private void txtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.sololetras(e, txtEmpresa, txtCorreo);
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ln(e, txtCorreo, txtRuc);
        }

        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumeros(e, txtRuc, txtPagina);
        }

        private void txtPagina_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ln(e, txtPagina, txtDir);
        }

        private void txtDir_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validar.ln(e, txtDir, txtRepre);
        }

        private void txtRepre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.sololetras(e, txtRepre, txtCelular);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumeros(e, txtCelular, txtCelular);
        }

        private void cbDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
