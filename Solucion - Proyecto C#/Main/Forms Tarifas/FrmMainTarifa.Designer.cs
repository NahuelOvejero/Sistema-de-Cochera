namespace Main.Forms_Tarifas
{
    partial class FrmMainTarifa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTarifas = new System.Windows.Forms.DataGridView();
            this.btnNewTarifa = new System.Windows.Forms.Button();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.cbBajas = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblbsq = new System.Windows.Forms.Label();
            this.cbFiltroT = new System.Windows.Forms.ComboBox();
            this.tbBusquedaT = new System.Windows.Forms.TextBox();
            this.btnModT = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnDarAlta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifas)).BeginInit();
            this.pnlBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTarifas
            // 
            this.dgvTarifas.AllowUserToAddRows = false;
            this.dgvTarifas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTarifas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarifas.Location = new System.Drawing.Point(12, 21);
            this.dgvTarifas.Name = "dgvTarifas";
            this.dgvTarifas.ReadOnly = true;
            this.dgvTarifas.RowHeadersVisible = false;
            this.dgvTarifas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTarifas.Size = new System.Drawing.Size(397, 199);
            this.dgvTarifas.TabIndex = 0;
            this.dgvTarifas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarifas_RowEnter);
            // 
            // btnNewTarifa
            // 
            this.btnNewTarifa.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNewTarifa.Location = new System.Drawing.Point(415, 21);
            this.btnNewTarifa.Name = "btnNewTarifa";
            this.btnNewTarifa.Size = new System.Drawing.Size(75, 39);
            this.btnNewTarifa.TabIndex = 1;
            this.btnNewTarifa.Text = "Nueva Tarifa";
            this.btnNewTarifa.UseVisualStyleBackColor = false;
            this.btnNewTarifa.Click += new System.EventHandler(this.btnNewTarifa_Click);
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBusqueda.Controls.Add(this.cbBajas);
            this.pnlBusqueda.Controls.Add(this.label2);
            this.pnlBusqueda.Controls.Add(this.label1);
            this.pnlBusqueda.Controls.Add(this.lblbsq);
            this.pnlBusqueda.Controls.Add(this.cbFiltroT);
            this.pnlBusqueda.Controls.Add(this.tbBusquedaT);
            this.pnlBusqueda.Location = new System.Drawing.Point(496, 21);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(155, 199);
            this.pnlBusqueda.TabIndex = 5;
            // 
            // cbBajas
            // 
            this.cbBajas.AutoSize = true;
            this.cbBajas.Location = new System.Drawing.Point(8, 161);
            this.cbBajas.Name = "cbBajas";
            this.cbBajas.Size = new System.Drawing.Size(135, 17);
            this.cbBajas.TabIndex = 5;
            this.cbBajas.Text = "Mostrar Tarifas de Baja";
            this.cbBajas.UseVisualStyleBackColor = true;
            this.cbBajas.CheckedChanged += new System.EventHandler(this.cbBajas_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Buscar:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filtar Por:";
            // 
            // lblbsq
            // 
            this.lblbsq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblbsq.AutoSize = true;
            this.lblbsq.Location = new System.Drawing.Point(25, 4);
            this.lblbsq.Name = "lblbsq";
            this.lblbsq.Size = new System.Drawing.Size(88, 13);
            this.lblbsq.TabIndex = 6;
            this.lblbsq.Text = "Busqueda Tarifa:";
            // 
            // cbFiltroT
            // 
            this.cbFiltroT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroT.FormattingEnabled = true;
            this.cbFiltroT.Items.AddRange(new object[] {
            "Nombre",
            "Precio",
            "Descripcion"});
            this.cbFiltroT.Location = new System.Drawing.Point(16, 58);
            this.cbFiltroT.Name = "cbFiltroT";
            this.cbFiltroT.Size = new System.Drawing.Size(121, 21);
            this.cbFiltroT.TabIndex = 3;
            this.cbFiltroT.SelectedIndexChanged += new System.EventHandler(this.cbFiltroT_SelectedIndexChanged);
            // 
            // tbBusquedaT
            // 
            this.tbBusquedaT.Location = new System.Drawing.Point(16, 115);
            this.tbBusquedaT.Name = "tbBusquedaT";
            this.tbBusquedaT.Size = new System.Drawing.Size(121, 20);
            this.tbBusquedaT.TabIndex = 4;
            this.tbBusquedaT.TextChanged += new System.EventHandler(this.tbBusquedaT_TextChanged);
            // 
            // btnModT
            // 
            this.btnModT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModT.Location = new System.Drawing.Point(415, 74);
            this.btnModT.Name = "btnModT";
            this.btnModT.Size = new System.Drawing.Size(75, 37);
            this.btnModT.TabIndex = 2;
            this.btnModT.Text = "Modificar Tarifa";
            this.btnModT.UseVisualStyleBackColor = false;
            this.btnModT.Click += new System.EventHandler(this.btnModT_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.BackColor = System.Drawing.Color.IndianRed;
            this.btnBaja.Location = new System.Drawing.Point(415, 125);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 38);
            this.btnBaja.TabIndex = 3;
            this.btnBaja.Text = "Dar de Baja";
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnDarAlta
            // 
            this.btnDarAlta.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDarAlta.Location = new System.Drawing.Point(415, 177);
            this.btnDarAlta.Name = "btnDarAlta";
            this.btnDarAlta.Size = new System.Drawing.Size(75, 41);
            this.btnDarAlta.TabIndex = 4;
            this.btnDarAlta.Text = "Dar de Alta";
            this.btnDarAlta.UseVisualStyleBackColor = false;
            this.btnDarAlta.Click += new System.EventHandler(this.btnDarAlta_Click);
            // 
            // FrmMainTarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 255);
            this.Controls.Add(this.btnDarAlta);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModT);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.btnNewTarifa);
            this.Controls.Add(this.dgvTarifas);
            this.Name = "FrmMainTarifa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarifas";
            this.Load += new System.EventHandler(this.frmMainTarifa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifas)).EndInit();
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTarifas;
        private System.Windows.Forms.Button btnNewTarifa;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.CheckBox cbBajas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblbsq;
        private System.Windows.Forms.ComboBox cbFiltroT;
        private System.Windows.Forms.TextBox tbBusquedaT;
        private System.Windows.Forms.Button btnModT;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnDarAlta;
    }
}