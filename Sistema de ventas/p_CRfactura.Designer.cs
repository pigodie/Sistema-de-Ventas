namespace Sistema_de_ventas
{
    partial class p_CRfactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crFactura = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crFactura
            // 
            this.crFactura.ActiveViewIndex = -1;
            this.crFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crFactura.Cursor = System.Windows.Forms.Cursors.Default;
            this.crFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crFactura.Location = new System.Drawing.Point(0, 0);
            this.crFactura.Name = "crFactura";
            this.crFactura.Size = new System.Drawing.Size(1084, 600);
            this.crFactura.TabIndex = 0;
            this.crFactura.Load += new System.EventHandler(this.crFactura_Load);
            // 
            // p_CRfactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 600);
            this.Controls.Add(this.crFactura);
            this.Name = "p_CRfactura";
            this.Text = "p_CRfactura";
            this.Activated += new System.EventHandler(this.p_CRfactura_Activated);
            this.Load += new System.EventHandler(this.p_CRfactura_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crFactura;
    }
}