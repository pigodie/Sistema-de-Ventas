using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_ventas
{
    public partial class Menu_principal : Form
    {
        public Menu_principal()
        {
            InitializeComponent();
           
            
        }


        

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*private Form activeForm = null;
        private void openChildForm(Form chilForm) {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = chilForm;

                chilForm.TopLevel = false;
                chilForm.FormBorderStyle = FormBorderStyle.None;
                chilForm.Dock = DockStyle.Fill;
                    
                panelContenedor.Controls.Add(chilForm);
                panelContenedor.Tag = chilForm;
                chilForm.BringToFront();
                chilForm.Show();

            }*/
        private void abrirformhijo(object formhijo) {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();


            
            
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        void redondear() {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, picturePv.Width - 3, picturePv.Height - 3);
            Region rg = new Region(gp);
            
            picturePv.Region = rg;
        }
        void coloresBotones() {
            btnUsuario.BackColor = Color.FromArgb(51, 51, 76);
            btnCliente.BackColor = Color.FromArgb(51, 51, 76);
            btnProducto.BackColor = Color.FromArgb(51, 51, 76);
            btnVentas.BackColor = Color.FromArgb(51, 51, 76);
            btnReporteFac.BackColor = Color.FromArgb(51, 51, 76);
        } 
        private void btnCliente_Click(object sender, EventArgs e)
        {
            //openChildForm(new p_cliente());
            Menu_principal_Load(sender, e);
            btnCliente.BackColor = Color.FromArgb(17, 97, 238);
            abrirformhijo(new p_cliente());
            

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
           

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Menu_principal_Load(sender, e);
            abrirformhijo(new p_usuario());
            btnUsuario.BackColor = Color.FromArgb(17, 97, 238);
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            Menu_principal_Load(sender, e);
            abrirformhijo(new p_producto());
            btnProducto.BackColor  = Color.FromArgb(17, 97, 238);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Menu_principal_Load(sender, e);
            abrirformhijo(new p_factura());
            btnVentas.BackColor = Color.FromArgb(17, 97, 238);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_principal_Load(object sender, EventArgs e)
        {
            coloresBotones();
            if (lblRol.Text == "Vendedor")
            {
                btnUsuario.Enabled = false;
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Menu_principal_Load(sender, e);
            abrirformhijo(new p_reporteFac());
            btnReporteFac.BackColor = Color.FromArgb(17, 97, 238);
        }

        private void picturePv_Click(object sender, EventArgs e)
        {

        }
    }
}
