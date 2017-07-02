namespace Main.Forms_Alquiler
{
    partial class FrmNewAlquiler
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
            this.btnVeh = new System.Windows.Forms.Button();
            this.tbVeh = new System.Windows.Forms.TextBox();
            this.btnLote = new System.Windows.Forms.Button();
            this.tbLote = new System.Windows.Forms.TextBox();
            this.btnTarf = new System.Windows.Forms.Button();
            this.tbTarifa = new System.Windows.Forms.TextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.pnlTiempo = new System.Windows.Forms.Panel();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.cbSalidaDefinida = new System.Windows.Forms.CheckBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.cbPago = new System.Windows.Forms.CheckBox();
            this.pnlTiempo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVeh
            // 
            this.btnVeh.Location = new System.Drawing.Point(216, 16);
            this.btnVeh.Name = "btnVeh";
            this.btnVeh.Size = new System.Drawing.Size(118, 20);
            this.btnVeh.TabIndex = 0;
            this.btnVeh.Text = "Seleccionar Vehiculo";
            this.btnVeh.UseVisualStyleBackColor = true;
            this.btnVeh.Click += new System.EventHandler(this.btnVeh_Click);
            // 
            // tbVeh
            // 
            this.tbVeh.Location = new System.Drawing.Point(28, 16);
            this.tbVeh.Name = "tbVeh";
            this.tbVeh.ReadOnly = true;
            this.tbVeh.Size = new System.Drawing.Size(165, 20);
            this.tbVeh.TabIndex = 1;
            this.tbVeh.Text = "<Sin Seleccionar>";
            // 
            // btnLote
            // 
            this.btnLote.Location = new System.Drawing.Point(216, 63);
            this.btnLote.Name = "btnLote";
            this.btnLote.Size = new System.Drawing.Size(118, 20);
            this.btnLote.TabIndex = 1;
            this.btnLote.Text = "Seleccionar Lote";
            this.btnLote.UseVisualStyleBackColor = true;
            this.btnLote.Click += new System.EventHandler(this.btnLote_Click);
            // 
            // tbLote
            // 
            this.tbLote.Location = new System.Drawing.Point(28, 63);
            this.tbLote.Name = "tbLote";
            this.tbLote.ReadOnly = true;
            this.tbLote.Size = new System.Drawing.Size(165, 20);
            this.tbLote.TabIndex = 1;
            this.tbLote.Text = "<Sin Seleccionar>";
            // 
            // btnTarf
            // 
            this.btnTarf.Location = new System.Drawing.Point(216, 113);
            this.btnTarf.Name = "btnTarf";
            this.btnTarf.Size = new System.Drawing.Size(118, 20);
            this.btnTarf.TabIndex = 2;
            this.btnTarf.Text = "Seleccionar Tarifa";
            this.btnTarf.UseVisualStyleBackColor = true;
            this.btnTarf.Click += new System.EventHandler(this.btnTarf_Click);
            // 
            // tbTarifa
            // 
            this.tbTarifa.Location = new System.Drawing.Point(28, 113);
            this.tbTarifa.Name = "tbTarifa";
            this.tbTarifa.ReadOnly = true;
            this.tbTarifa.Size = new System.Drawing.Size(165, 20);
            this.tbTarifa.TabIndex = 1;
            this.tbTarifa.Text = "<Sin Seleccionar>";
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAñadir.Location = new System.Drawing.Point(112, 226);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(128, 50);
            this.btnAñadir.TabIndex = 5;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // pnlTiempo
            // 
            this.pnlTiempo.Controls.Add(this.dtpSalida);
            this.pnlTiempo.Controls.Add(this.cbSalidaDefinida);
            this.pnlTiempo.Enabled = false;
            this.pnlTiempo.Location = new System.Drawing.Point(12, 164);
            this.pnlTiempo.Name = "pnlTiempo";
            this.pnlTiempo.Size = new System.Drawing.Size(338, 56);
            this.pnlTiempo.TabIndex = 3;
            // 
            // dtpSalida
            // 
            this.dtpSalida.Location = new System.Drawing.Point(129, 18);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(200, 20);
            this.dtpSalida.TabIndex = 1;
            this.dtpSalida.ValueChanged += new System.EventHandler(this.dtpSalida_ValueChanged);
            // 
            // cbSalidaDefinida
            // 
            this.cbSalidaDefinida.AutoSize = true;
            this.cbSalidaDefinida.Location = new System.Drawing.Point(10, 21);
            this.cbSalidaDefinida.Name = "cbSalidaDefinida";
            this.cbSalidaDefinida.Size = new System.Drawing.Size(97, 17);
            this.cbSalidaDefinida.TabIndex = 0;
            this.cbSalidaDefinida.Text = "Salida Definida";
            this.cbSalidaDefinida.UseVisualStyleBackColor = true;
            this.cbSalidaDefinida.CheckedChanged += new System.EventHandler(this.cbSalidaDefinida_CheckedChanged);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(272, 255);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(55, 13);
            this.lblMonto.TabIndex = 5;
            this.lblMonto.Text = "Monto: $0";
            this.lblMonto.Click += new System.EventHandler(this.lblMonto_Click);
            // 
            // cbPago
            // 
            this.cbPago.AutoSize = true;
            this.cbPago.Location = new System.Drawing.Point(264, 235);
            this.cbPago.Name = "cbPago";
            this.cbPago.Size = new System.Drawing.Size(70, 17);
            this.cbPago.TabIndex = 4;
            this.cbPago.Text = "Pre-Pago";
            this.cbPago.UseVisualStyleBackColor = true;
            // 
            // FrmNewAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 292);
            this.Controls.Add(this.cbPago);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.pnlTiempo);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.tbTarifa);
            this.Controls.Add(this.tbLote);
            this.Controls.Add(this.tbVeh);
            this.Controls.Add(this.btnTarf);
            this.Controls.Add(this.btnLote);
            this.Controls.Add(this.btnVeh);
            this.Name = "FrmNewAlquiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Alquiler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNewAlquiler_FormClosing);
            this.Load += new System.EventHandler(this.FrmNewAlquiler_Load);
            this.pnlTiempo.ResumeLayout(false);
            this.pnlTiempo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVeh;
        private System.Windows.Forms.TextBox tbVeh;
        private System.Windows.Forms.Button btnLote;
        private System.Windows.Forms.TextBox tbLote;
        private System.Windows.Forms.Button btnTarf;
        private System.Windows.Forms.TextBox tbTarifa;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Panel pnlTiempo;
        private System.Windows.Forms.CheckBox cbSalidaDefinida;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.CheckBox cbPago;
    }
}