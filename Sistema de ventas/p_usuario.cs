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
using System.Security.Cryptography;
namespace Sistema_de_ventas
{
    public partial class p_usuario : Form
    {
        n_usuario obNeUser = new n_usuario();
        e_usuario obEnUser = new e_usuario();
        Encrypt encrypt = new Encrypt();
        Validar validar = new Validar();
        String id="";
        int a = 0;
        
        public p_usuario()
        {
            InitializeComponent();
            
            cbCargo.Items.Add("Administrador");
            cbCargo.Items.Add("Vendedor");
            cbCargo.Items.Add("Almacenero");
            

        }

        void limpiar() {
            validar.limpiar(this);
        }
        void sape() {
            txtPass.AutoSize = false;
            txtNombre.AutoSize = false;
            txtDni.AutoSize = false;
            txtBusqueda.AutoSize = false;
            txtApellido.AutoSize = false;
            txtUser.AutoSize = false;

            txtUser.Size = new Size(144, 25);
            txtPass.Size = new Size(144, 25);
            txtNombre.Size = new Size(144, 25);
            txtDni.Size = new Size(144, 25);
            txtBusqueda.Size = new Size(144, 25);
            txtApellido.Size = new Size(144, 25);

        }
      

        void setear(String id)
        {
            
            String passEncryp =  encrypt.sha256(txtPass.Text);
            obEnUser.dni = txtDni.Text;
            obEnUser.nombre = txtNombre.Text.ToString();
            obEnUser.apellido = txtApellido.Text;
            obEnUser.cargo = cbCargo.Text;
            
            obEnUser.usuario = txtUser.Text;
            obEnUser.pass = passEncryp;
            obEnUser.id = id;
           
         

        }
        void llenarTextboxDgv()
        {

            id = dgvUsuario.CurrentRow.Cells[0].Value.ToString();
            txtDni.Text = dgvUsuario.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dgvUsuario.CurrentRow.Cells[2].Value.ToString();
            txtApellido.Text = dgvUsuario.CurrentRow.Cells[3].Value.ToString();
            cbCargo.Text = dgvUsuario.CurrentRow.Cells[4].Value.ToString();
            txtPass.Text = dgvUsuario.CurrentRow.Cells[6].Value.ToString();
        
            
        }
        void listarUsuario()
        {
            DataTable dt = obNeUser.mostrarUser();
            dgvUsuario.DataSource = dt;
            dgvUsuario.Columns[0].Visible = false;

        }

        void filtrarUsuario() {
            obEnUser.dni = txtBusqueda.Text;
            DataTable dt = obNeUser.filtrarUsuario(obEnUser);
            if (dt.Rows.Count>0)
            {
                //dgvUsuario.DataSource = null;
                dgvUsuario.DataSource = dt;
            }
            else
            {
                listarUsuario();
            }
           
        }
        void botones(bool agregar, bool editar, bool nuevo, bool eliminar)
        {
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

        void validarAgregar() {
            if (txtPass.TextLength>0 && txtNombre.TextLength>0 && txtApellido.TextLength>0 && txtDni.TextLength>0 && a ==0)
            {
                botones(true, true, true, true);
            }
            else
            {
                //botones(false, false, true, false);
            }
           
        }
        void autocompletar()
        {

            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            DataTable dt = obNeUser.mostrarUser();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //txtBusqueda.Text = i.ToString();
                lista.Add(dt.Rows[i]["dni"].ToString());
            }
            txtBusqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBusqueda.AutoCompleteCustomSource = lista;

        }

        private void p_usuario_Load(object sender, EventArgs e)
        {
            sape();
            autocompletar();
            botones(false, false, true, false);
            validar.limpiar(panelDatos);
            txtBusqueda.Text = "";
            listarUsuario();
            txtUser.Visible = true;
            lblUser.Visible = true;
            a = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            setear(id);
            obNeUser.agregarUsuario(obEnUser);
            p_usuario_Load(sender, e);


        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validarAgregar();
        }

        private void txtRol_TextChanged(object sender, EventArgs e)
        {
      
      
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            validarAgregar();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            setear(id);
            obNeUser.modificarUsuario(obEnUser);
            p_usuario_Load(sender, e);
            
        }

       

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            lblUser.Visible = false;
            txtUser.Visible = false;
            llenarTextboxDgv();
            botones(false, true, true, true);
            a = 1;
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            setear(id);
            obNeUser.eliminarUsuario(obEnUser);
            p_usuario_Load(sender,e);


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            validarAgregar();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            validarAgregar();
        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarAgregar();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            validarAgregar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            p_usuario_Load(sender,e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.sololetras(e, txtNombre, txtApellido);
        }

        private void txtApellido_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtDni_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.sololetras(e, txtApellido, txtDni);
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumeros(e, txtDni, txtUser);
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ln(e, txtUser, txtPass);
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ln(e, txtPass, txtPass);
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            filtrarUsuario();
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumeros(e, txtBusqueda, txtBusqueda);
        }
    }
}
