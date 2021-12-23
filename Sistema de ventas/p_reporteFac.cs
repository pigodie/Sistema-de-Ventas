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
    public partial class p_reporteFac : Form
    {
        e_reporteFac objReporteFac = new e_reporteFac();
        e_factura objEnFac = new e_factura();
        n_factura objNeFac = new n_factura();
        n_usuario objNeUser = new n_usuario();
        n_cliente objNeCli = new n_cliente();
        n_reporteFac objReporte = new n_reporteFac();

       
        int accionn = 5;
        public p_reporteFac()
        {
            InitializeComponent();
        }

       

        void autocompletarDni()
        {


            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            DataTable dt = objNeUser.mostrarUser();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //txtBusqueda.Text = i.ToString();
                lista.Add(dt.Rows[i]["apellido"].ToString());
            }
            txtEmpleado.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtEmpleado.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtEmpleado.AutoCompleteCustomSource = lista;

        }

        void autocompletarRuc()
        {

            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            DataTable dt = objNeCli.mostrarClientes();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //txtBusqueda.Text = i.ToString();
                lista.Add(dt.Rows[i]["empresa"].ToString());
            }
            txtEmpresa.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtEmpresa.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtEmpresa.AutoCompleteCustomSource = lista;

        }
        void setear() {
            objReporteFac.usuario = txtEmpleado.Text;
            objReporteFac.empresa = txtEmpresa.Text;
            objReporteFac.fecInicio = dtpInicio.Value;
            objReporteFac.fecFinal = dtpFinal.Value;

        }

        void rellenarDgv() {
            DataTable dt = objNeFac.listarFactura();
            dgvReporteFac.DataSource = dt;
        }
        void activarTextbox() {
            if (rbCliente.Checked) { txtEmpresa.Enabled = true; accionn = 2; } else { txtEmpresa.Enabled = false; }

            if (rbEmpleado.Checked) { txtEmpleado.Enabled = true; accionn = 1;
            } else { txtEmpleado.Enabled = false; }

            if (rbFechas.Checked) { dtpInicio.Enabled = true; dtpFinal.Enabled = true; accionn = 3; } 
            else { dtpInicio.Enabled = false; dtpFinal.Enabled = false; }

            
        }
        void limpiar() {
            txtEmpresa.Text = "";
            txtEmpleado.Text = "";
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.CustomFormat = " ";

            dtpFinal.Format = DateTimePickerFormat.Custom;
            dtpFinal.CustomFormat = " ";
          



            //dtpFinal.Value=null;
        }
        private void p_reporteFac_Load(object sender, EventArgs e)
        {
            accionn = 5;
            rbCliente.Checked = false;
            rbEmpleado.Checked = false;
            rbFechas.Checked = false;
            limpiar();
            rellenarDgv();
           autocompletarDni();
            autocompletarRuc();
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
         
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            p_CRfactura crfac = new p_CRfactura();
            crfac.accion = accionn;
            crfac.usuario = txtEmpleado.Text;
            crfac.empresa = txtEmpresa.Text;
            crfac.Show();
        }

        private void rbEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            activarTextbox();

        }

        private void rbCliente_CheckedChanged(object sender, EventArgs e)
        {
            activarTextbox();
            
        }

        private void rbFechas_CheckedChanged(object sender, EventArgs e)
        {
            activarTextbox();
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            setear();
            DataTable dt = objReporte.FiltarFactura(objReporteFac, accionn);
            dgvReporteFac.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p_reporteFac_Load(sender, e);
        }
    }
}
