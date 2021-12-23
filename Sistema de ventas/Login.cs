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
using System.Security.Cryptography;

namespace Sistema_de_ventas
{
    public partial class Login : Form
    {
     
        
        n_usuario objNeUser = new n_usuario();
        e_usuario objEntUser = new e_usuario();
        Validar validar = new Validar();
        Encrypt encrypt = new Encrypt();
        public Login()
        {
            InitializeComponent();
        }





        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
         

            }

            private void txtUsuario_MouseEnter(object sender, EventArgs e)
            {
              

            }

            private void txtPass_MouseEnter(object sender, EventArgs e)
            {
              

            }

            private void txtUsuario_MouseLeave(object sender, EventArgs e)
            {
             
            }

            private void txtPass_MouseLeave(object sender, EventArgs e)
            {
               
            }

            private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
            {
                validar.sololetras(e, txtUsuario, txtUsuario);
              
            }

            private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
            {

            txtPass.PasswordChar = '*';
            }

            private void Login_Load(object sender, EventArgs e)
            {
            txtUsuario.AutoSize = false;
            txtPass.AutoSize = false;
            txtUsuario.Size = new Size(230, 22);
            txtPass.Size = new Size(230, 22);
           

           
            }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           /* String passEncrypt = encrypt.sha256(txtPass.Text);
            dt = objNeUser.n_acceso(txtUsuario.Text, passEncrypt);
            

            if (dt.Rows.Count > 0)
            {
               
                
                var nom = dt.Rows[0]["nombreUsuario"].ToString();
                var idcargo = dt.Rows[0]["idcargo"].ToString();
                dt1 = objNeUser.getCargo(idcargo);
                var nomcargo = dt1.Rows[0]["nombrecargo"].ToString();

                Menu_principal frm = new Menu_principal();
                frm.lblNombre.Text = "hgshgdhdf";

                frm.lblRol.Text = idcargo;
                frm.Show();
            }
            else
            {
                lblMensaje.Text = "Usuario o contraseña incorrecta";
              
            }*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String passEncrypt = encrypt.sha256(txtPass.Text);
             DataTable dt = objNeUser.n_acceso(txtUsuario.Text, passEncrypt);

            if (dt.Rows.Count > 0)
            {


                String nom = dt.Rows[0]["nombreUsuario"].ToString();
                String idcargo = dt.Rows[0]["idcargo"].ToString();
                DataTable dt1 = objNeUser.getCargo(idcargo);
                String rol="nada";
                if (dt1.Rows.Count>0)
                {
                     rol = dt1.Rows[0]["nombrecargo"].ToString();
                }
                

                Menu_principal frm = new Menu_principal();
                frm.lblNombre.Text = nom;
                frm.lblRol.Text = rol;
                frm.Show();

            }
            else
            {
                lblMensaje.Text = "Usuario o contraseña incorrecta";

            }
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
    }

