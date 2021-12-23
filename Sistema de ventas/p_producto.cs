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
    public partial class p_producto : Form
    {
        Validar validar = new Validar();
        n_producto objNePro = new n_producto();
        e_producto objEnPro = new e_producto();
        String id;
        public p_producto()
        {
            InitializeComponent();
        }

        void autocompletar()
        {

            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            DataTable dt = objNePro.listarProducto();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //txtBusqueda.Text = i.ToString();
                lista.Add(dt.Rows[i]["codigo"].ToString());
            }
            txtBusqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBusqueda.AutoCompleteCustomSource = lista;

        }
        void filtrarProducto() {
            objEnPro.Codigo = txtBusqueda.Text;
            DataTable dt = objNePro.listarProductoCod(objEnPro);
            if (dt.Rows.Count>0)
            {
 
                dgvProducto.DataSource = dt;
            }
            else
            {
                listarProducto();
            }
         

        }
        void activar() {
            txtPrecio.Enabled = true;
            txtCodigo.Enabled = true;
            txtNombre.Enabled = true;
            txtCant.Enabled = true;
            cbcategoria.Enabled = true;

            txtNombre.BackColor = Color.FromArgb(80, 94, 127);
            txtCodigo.BackColor = Color.FromArgb(80, 94, 127);
        }
        void rellenarTextbox() {

            txtCodigo.Enabled = false;
            txtNombre.Enabled = false;
           
            txtCodigo.BackColor = Color.FromArgb(46, 59, 104);
            txtNombre.BackColor = Color.FromArgb(46, 59, 104);
            cbcategoria.BackColor = Color.FromArgb(46, 59, 104);

            id = dgvProducto.CurrentRow.Cells[0].Value.ToString();
            txtCodigo.Text = dgvProducto.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dgvProducto.CurrentRow.Cells[2].Value.ToString();
            txtCant.Text = dgvProducto.CurrentRow.Cells[3].Value.ToString();
            txtPrecio.Text = dgvProducto.CurrentRow.Cells[4].Value.ToString();
            cbcategoria.Text = dgvProducto.CurrentRow.Cells[5].Value.ToString();



        }
        void listarCategoria()
        {
            DataTable dt = objNePro.listarCategoria();
            cbcategoria.DisplayMember = "nombrecategoria";
            cbcategoria.ValueMember = "idcategoria";
            cbcategoria.DataSource = dt;
        }
        void setear(string id) {
            objEnPro.Codigo = txtCodigo.Text;
            objEnPro.Id = id;
            objEnPro.Nombre = txtNombre.Text;
            objEnPro.Stock = txtCant.Text;
            objEnPro.Precio = txtPrecio.Text;
            int cat = cbcategoria.SelectedIndex + 1;
            objEnPro.categoria = "1";
        }
        void listarProducto() {
            DataTable dt = objNePro.listarProducto();
            dgvProducto.DataSource = dt;
            dgvProducto.Columns["Id"].Visible = false;
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

        private void p_producto_Load(object sender, EventArgs e)
        {
            cbcategoria.Visible = false;
            txtBusqueda.Text = "";
            autocompletar();
            listarCategoria();
            listarProducto();
            activar();
            validar.limpiar(panelDatos);
            botones(false, false, true, false);

        }
        void ValidarAgregar() {
            if (txtCodigo.TextLength > 0 && txtNombre.TextLength > 0 && txtPrecio.TextLength > 0 && txtCant.TextLength > 0)
            {
                botones(true, true, true, true);
            }
            else {
                botones(false, false, true, false);
            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rellenarTextbox();
            botones(false, true, true, true);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            setear("");
            objNePro.agregarProducto(objEnPro);
            p_producto_Load(sender, e);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            setear(id);
            objNePro.editarProducto(objEnPro);
            p_producto_Load(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            setear(id);
            objNePro.eliminarProducto(objEnPro);
            p_producto_Load(sender, e);

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            filtrarProducto();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ValidarAgregar();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarAgregar();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            ValidarAgregar();
        }

        private void txtCant_TextChanged(object sender, EventArgs e)
        {
            ValidarAgregar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            p_producto_Load(sender, e);
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.sololetras(e, txtNombre, txtCant);
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ln(e, txtCodigo, txtNombre);
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumeros(e, txtCant, txtPrecio);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumeros(e, txtPrecio, txtPrecio);
        }
    }
}
