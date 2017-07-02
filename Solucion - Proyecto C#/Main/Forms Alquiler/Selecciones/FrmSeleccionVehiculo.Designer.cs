namespace Main.Forms_Alquiler.Selecciones
{
    partial class FrmSeleccionVehiculo
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
            this.dgvVehiculo = new System.Windows.Forms.DataGridView();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFiltroV = new System.Windows.Forms.ComboBox();
            this.tbBusquedaV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVehiculo
            // 
            this.dgvVehiculo.AllowUserToAddRows = false;
            this.dgvVehiculo.AllowUserToDeleteRows = false;
            this.dgvVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculo.Location = new System.Drawing.Point(10, 6);
            this.dgvVehiculo.Name = "dgvVehiculo";
            this.dgvVehiculo.ReadOnly = true;
            this.dgvVehiculo.RowHeadersVisible = false;
            this.dgvVehiculo.Size = new System.Drawing.Size(496, 250);
            this.dgvVehiculo.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(312, 294);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(123, 45);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Seleccionar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbFiltroV);
            this.panel1.Controls.Add(this.tbBusquedaV);
            this.panel1.Location = new System.Drawing.Point(61, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 122);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrar Por:";
            // 
            // cbFiltroV
            // 
            this.cbFiltroV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroV.FormattingEnabled = true;
            this.cbFiltroV.Items.AddRange(new object[] {
            "Patente",
            "Modelo",
            "Color",
            "Tipo",
            "Observaciones"});
            this.cbFiltroV.Location = new System.Drawing.Point(23, 30);
            this.cbFiltroV.Name = "cbFiltroV";
            this.cbFiltroV.Size = new System.Drawing.Size(121, 21);
            this.cbFiltroV.TabIndex = 0;
            // 
            // tbBusquedaV
            // 
            this.tbBusquedaV.Location = new System.Drawing.Point(23, 82);
            this.tbBusquedaV.Name = "tbBusquedaV";
            this.tbBusquedaV.Size = new System.Drawing.Size(121, 20);
            this.tbBusquedaV.TabIndex = 1;
            this.tbBusquedaV.TextChanged += new System.EventHandler(this.tbBusquedaV_TextChanged);
            // 
            // FrmSeleccionVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 396);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dgvVehiculo);
            this.Name = "FrmSeleccionVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione un Vehiculo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSeleccionVehiculo_FormClosing);
            this.Load += new System.EventHandler(this.frmSeleccionVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehiculo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbBusquedaV;
        private System.Windows.Forms.ComboBox cbFiltroV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}