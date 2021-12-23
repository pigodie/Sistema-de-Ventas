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
    public partial class p_CRfactura : Form
    {
        n_reporteFac objNeReFac = new n_reporteFac();
        e_reporteFac objEnReFac = new e_reporteFac();
        p_reporteFac pReFac = new p_reporteFac();

        public int accion;
        public String usuario;
        public String empresa;
        DateTime inicio ;
        DateTime final ;

        public p_CRfactura()
        {
            InitializeComponent();
            
        }
        void cargar() {
            reporteFactura objRfac = new reporteFactura();
            objRfac.SetParameterValue("@usuario",usuario);
            objRfac.SetParameterValue("@empresa", empresa);
            objRfac.SetParameterValue("@fec1",null);
            objRfac.SetParameterValue("@fec2", null);
            objRfac.SetParameterValue("@accion",accion);
            crFactura.ReportSource = objRfac;
            
        }

        private void crFactura_Load(object sender, EventArgs e)
        {
           
        }

        private void p_CRfactura_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void p_CRfactura_Activated(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
