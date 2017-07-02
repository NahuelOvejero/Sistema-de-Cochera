namespace Main.Forms_Lote
{
    partial class FrmLotes
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
            this.dgvLotes = new System.Windows.Forms.DataGridView();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.pnlMod = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.cbBusqueda = new System.Windows.Forms.ComboBox();
            this.pnlLeyenda = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbMod = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbCarga = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotes)).BeginInit();
            this.pnlMod.SuspendLayout();
            this.pnlBusqueda.SuspendLayout();
            this.pnlLeyenda.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLotes
            // 
            this.dgvLotes.AllowUserToAddRows = false;
            this.dgvLotes.AllowUserToDeleteRows = false;
            this.dgvLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLotes.Location = new System.Drawing.Point(21, 25);
            this.dgvLotes.Name = "dgvLotes";
            this.dgvLotes.ReadOnly = true;
            this.dgvLotes.RowHeadersVisible = false;
            this.dgvLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLotes.Size = new System.Drawing.Size(281, 150);
            this.dgvLotes.TabIndex = 0;
            this.dgvLotes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLotes_RowEnter);
            // 
            // btnCambiar
            // 
            this.btnCambiar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCambiar.Location = new System.Drawing.Point(102, 115);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(75, 23);
            this.btnCambiar.TabIndex = 3;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = false;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Libre",
            "Mantenimiento",
            "Baja"});
            this.cbEstado.Location = new System.Drawing.Point(103, 12);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 0;
            // 
            // pnlMod
            // 
            this.pnlMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMod.Controls.Add(this.label10);
            this.pnlMod.Controls.Add(this.cbTipo);
            this.pnlMod.Controls.Add(this.tbNombre);
            this.pnlMod.Controls.Add(this.label2);
            this.pnlMod.Controls.Add(this.label1);
            this.pnlMod.Controls.Add(this.cbEstado);
            this.pnlMod.Controls.Add(this.btnCambiar);
            this.pnlMod.Location = new System.Drawing.Point(21, 224);
            this.pnlMod.Name = "pnlMod";
            this.pnlMod.Size = new System.Drawing.Size(281, 148);
            this.pnlMod.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Tipo:";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Auto",
            "Moto",
            "Camioneta",
            "Camion"});
            this.cbTipo.Location = new System.Drawing.Point(103, 72);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 2;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(103, 43);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(121, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Estado:";
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBusqueda.Controls.Add(this.label4);
            this.pnlBusqueda.Controls.Add(this.label3);
            this.pnlBusqueda.Controls.Add(this.tbBusqueda);
            this.pnlBusqueda.Controls.Add(this.cbBusqueda);
            this.pnlBusqueda.Location = new System.Drawing.Point(354, 25);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(141, 149);
            this.pnlBusqueda.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filtro:";
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Location = new System.Drawing.Point(8, 93);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(121, 20);
            this.tbBusqueda.TabIndex = 1;
            this.tbBusqueda.TextChanged += new System.EventHandler(this.tbBusqueda_TextChanged);
            // 
            // cbBusqueda
            // 
            this.cbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBusqueda.FormattingEnabled = true;
            this.cbBusqueda.Items.AddRange(new object[] {
            "Nombre",
            "Ocupado",
            "Libre",
            "Mantenimiento",
            "Baja"});
            this.cbBusqueda.Location = new System.Drawing.Point(8, 32);
            this.cbBusqueda.Name = "cbBusqueda";
            this.cbBusqueda.Size = new System.Drawing.Size(121, 21);
            this.cbBusqueda.TabIndex = 0;
            this.cbBusqueda.SelectedIndexChanged += new System.EventHandler(this.cbBusqueda_SelectedIndexChanged);
            // 
            // pnlLeyenda
            // 
            this.pnlLeyenda.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlLeyenda.Controls.Add(this.label8);
            this.pnlLeyenda.Controls.Add(this.label7);
            this.pnlLeyenda.Controls.Add(this.label6);
            this.pnlLeyenda.Controls.Add(this.label5);
            this.pnlLeyenda.Location = new System.Drawing.Point(344, 224);
            this.pnlLeyenda.Name = "pnlLeyenda";
            this.pnlLeyenda.Size = new System.Drawing.Size(151, 139);
            this.pnlLeyenda.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(26, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Amarillo = Ocupado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(13, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Naranja = Mantenimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(40, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Verde = Libre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(44, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rojo = Baja";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(395, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Leyenda:";
            // 
            // rbMod
            // 
            this.rbMod.AutoSize = true;
            this.rbMod.Location = new System.Drawing.Point(16, 1);
            this.rbMod.Name = "rbMod";
            this.rbMod.Size = new System.Drawing.Size(68, 17);
            this.rbMod.TabIndex = 0;
            this.rbMod.TabStop = true;
            this.rbMod.Text = "Modificar";
            this.rbMod.UseVisualStyleBackColor = true;
            this.rbMod.CheckedChanged += new System.EventHandler(this.rbMod_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbCarga);
            this.panel1.Controls.Add(this.rbMod);
            this.panel1.Location = new System.Drawing.Point(61, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 19);
            this.panel1.TabIndex = 1;
            // 
            // rbCarga
            // 
            this.rbCarga.AutoSize = true;
            this.rbCarga.Location = new System.Drawing.Point(129, 1);
            this.rbCarga.Name = "rbCarga";
            this.rbCarga.Size = new System.Drawing.Size(56, 17);
            this.rbCarga.TabIndex = 1;
            this.rbCarga.TabStop = true;
            this.rbCarga.Text = "Cargar";
            this.rbCarga.UseVisualStyleBackColor = true;
            // 
            // FrmLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 384);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pnlLeyenda);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.pnlMod);
            this.Controls.Add(this.dgvLotes);
            this.Name = "FrmLotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lotes";
            this.Load += new System.EventHandler(this.FrmLotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotes)).EndInit();
            this.pnlMod.ResumeLayout(false);
            this.pnlMod.PerformLayout();
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            this.pnlLeyenda.ResumeLayout(false);
            this.pnlLeyenda.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLotes;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Panel pnlMod;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.ComboBox cbBusqueda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlLeyenda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbMod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbCarga;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbTipo;
    }
}