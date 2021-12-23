using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_ventas
{
    class Validar
    {

        public void sololetras(KeyPressEventArgs e, TextBox c, TextBox t)
        {
            if (e.KeyChar == 13 && c.Text.Length > 0) { t.Enabled = true; t.Focus(); t.BackColor = Color.FromArgb(30, 38, 70); c.BackColor = Color.FromArgb(80, 94, 127); }
            if (!(Char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32)) e.Handled = true;
        }
        public void ln(KeyPressEventArgs e, TextBox c, TextBox t)
        {
            if (e.KeyChar == 13 && c.Text.Length > 0) { t.Enabled = true; t.Focus(); t.BackColor = Color.FromArgb(30, 38, 70); c.BackColor = Color.FromArgb(80, 94, 127); }
        }

        public void solonumeros(KeyPressEventArgs e, TextBox c, TextBox t)
        {
            if (e.KeyChar == 13 && c.Text.Length > 0) { t.Enabled = true; t.Focus(); t.BackColor = Color.FromArgb(30, 38, 70); c.BackColor = Color.FromArgb(80, 94, 127); }
            if (!(Char.IsDigit(e.KeyChar) || e.KeyChar == 8)) e.Handled = true;
        }

        public void solonumerosdecimales(KeyPressEventArgs e, TextBox c, TextBox t)
        {
            if (e.KeyChar == 13 && c.Text.Length > 0) { t.Enabled = true; t.Focus(); t.BackColor = Color.CadetBlue; c.BackColor = Color.White; }
            if (!(Char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46)) e.Handled = true;
        }

        public void ruc(KeyPressEventArgs e, TextBox c, TextBox t)
        {
            if (e.KeyChar == 13 && Convert.ToInt32(c.Text) > 10)
            {
                t.BackColor = Color.White;
                c.BackColor = Color.CadetBlue;
                c.Clear();
                c.Focus();
            }
        }

        public void limpiar(Control control)
        {
            foreach (Control obj in control.Controls)
            {
                if (obj is GroupBox)
                {
                    foreach (Control txt in obj.Controls)
                    {
                        if (txt is TextBox)
                        {
                            ((TextBox)txt).Clear();
                            ((TextBox)txt).Enabled = false;
                            ((TextBox)txt).BackColor = Color.White; ;
                        }
                        if (txt is CheckBox)
                        {
                            ((CheckBox)txt).Checked = false;
                        }
                        if (txt is RadioButton)
                        {
                            ((RadioButton)txt).Checked = false;
                        }
                    }


                }
                if (obj is TextBox)
                {
                    ((TextBox)obj).Clear();
                }
                if (obj is CheckBox)
                {
                    ((CheckBox)obj).Checked = false;
                }

            }
        }
    }
}




