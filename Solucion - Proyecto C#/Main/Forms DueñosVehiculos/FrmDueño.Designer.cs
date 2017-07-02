namespace Principal
{
    partial class FrmDueño
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
            this.dgvInquilinos = new System.Windows.Forms.DataGridView();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.btnEliminarI = new System.Windows.Forms.Button();
            this.btnNuevoInquilino = new System.Windows.Forms.Button();
            this.pnlBusquedaInq = new System.Windows.Forms.Panel();
            this.cbBajas = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblbsq = new System.Windows.Forms.Label();
            this.cbFiltroI = new System.Windows.Forms.ComboBox();
            this.tbBusquedaI = new System.Windows.Forms.TextBox();
            this.btnAñadirCoche = new System.Windows.Forms.Button();
            this.btnModInquilino = new System.Windows.Forms.Button();
            this.pnlBusquedaV = new System.Windows.Forms.Panel();
            this.cbBajasV = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFiltroV = new System.Windows.Forms.ComboBox();
            this.tbBusquedaV = new System.Windows.Forms.TextBox();
            this.btnModificarV = new System.Windows.Forms.Button();
            this.btnEliminarV = new System.Windows.Forms.Button();
            this.btnDarAlta = new System.Windows.Forms.Button();
            this.btnAltaV = new System.Windows.Forms.Button();
            this.btnCambiarDueño = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInquilinos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.pnlBusquedaInq.SuspendLayout();
            this.pnlBusquedaV.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInquilinos
            // 
            this.dgvInquilinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInquilinos.Location = new System.Drawing.Point(19, 10);
            this.dgvInquilinos.Name = "dgvInquilinos";
            this.dgvInquilinos.ReadOnly = true;
            this.dgvInquilinos.RowHeadersVisible = false;
            this.dgvInquilinos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInquilinos.Size = new System.Drawing.Size(405, 202);
            this.dgvInquilinos.TabIndex = 0;
            this.dgvInquilinos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInquilinos_CellContentClick);
            this.dgvInquilinos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInquilinos_RowEnter);
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Location = new System.Drawing.Point(19, 254);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.ReadOnly = true;
            this.dgvVehiculos.RowHeadersVisible = false;
            this.dgvVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculos.Size = new System.Drawing.Size(405, 188);
            this.dgvVehiculos.TabIndex = 0;
            this.dgvVehiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculos_CellContentClick);
            this.dgvVehiculos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculos_RowEnter);
            // 
            // btnEliminarI
            // 
            this.btnEliminarI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarI.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarI.Location = new System.Drawing.Point(446, 162);
            this.btnEliminarI.Name = "btnEliminarI";
            this.btnEliminarI.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarI.TabIndex = 3;
            this.btnEliminarI.Text = "Dar de Baja";
            this.btnEliminarI.UseVisualStyleBackColor = false;
            this.btnEliminarI.Click += new System.EventHandler(this.btnEliminarI_Click);
            // 
            // btnNuevoInquilino
            // 
            this.btnNuevoInquilino.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoInquilino.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNuevoInquilino.Location = new System.Drawing.Point(446, 13);
            this.btnNuevoInquilino.Name = "btnNuevoInquilino";
            this.btnNuevoInquilino.Size = new System.Drawing.Size(75, 52);
            this.btnNuevoInquilino.TabIndex = 0;
            this.btnNuevoInquilino.Text = "Agregar nuevo Inquilino";
            this.btnNuevoInquilino.UseVisualStyleBackColor = false;
            this.btnNuevoInquilino.Click += new System.EventHandler(this.btnNuevoInquilino_Click);
            // 
            // pnlBusquedaInq
            // 
            this.pnlBusquedaInq.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlBusquedaInq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBusquedaInq.Controls.Add(this.cbBajas);
            this.pnlBusquedaInq.Controls.Add(this.label2);
            this.pnlBusquedaInq.Controls.Add(this.label1);
            this.pnlBusquedaInq.Controls.Add(this.lblbsq);
            this.pnlBusquedaInq.Controls.Add(this.cbFiltroI);
            this.pnlBusquedaInq.Controls.Add(this.tbBusquedaI);
            this.pnlBusquedaInq.Location = new System.Drawing.Point(539, 13);
            this.pnlBusquedaInq.Name = "pnlBusquedaInq";
            this.pnlBusquedaInq.Size = new System.Drawing.Size(155, 199);
            this.pnlBusquedaInq.TabIndex = 6;
            // 
            // cbBajas
            // 
            this.cbBajas.AutoSize = true;
            this.cbBajas.Location = new System.Drawing.Point(19, 147);
            this.cbBajas.Name = "cbBajas";
            this.cbBajas.Size = new System.Drawing.Size(108, 30);
            this.cbBajas.TabIndex = 2;
            this.cbBajas.Text = "Mostrar Inquilinos\r\ndados de baja";
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
            this.lblbsq.Size = new System.Drawing.Size(100, 13);
            this.lblbsq.TabIndex = 6;
            this.lblbsq.Text = "Busqueda Inquilino:";
            // 
            // cbFiltroI
            // 
            this.cbFiltroI.AutoCompleteCustomSource.AddRange(new string[] {
            "",
            "DNI",
            "Nombre",
            "Apellido",
            "telefono"});
            this.cbFiltroI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroI.FormattingEnabled = true;
            this.cbFiltroI.Items.AddRange(new object[] {
            "Dni",
            "Nombre",
            "Apellido",
            "Telefono"});
            this.cbFiltroI.Location = new System.Drawing.Point(16, 58);
            this.cbFiltroI.Name = "cbFiltroI";
            this.cbFiltroI.Size = new System.Drawing.Size(121, 21);
            this.cbFiltroI.TabIndex = 0;
            this.cbFiltroI.SelectedIndexChanged += new System.EventHandler(this.cbFiltroI_SelectedIndexChanged);
            // 
            // tbBusquedaI
            // 
            this.tbBusquedaI.Location = new System.Drawing.Point(16, 115);
            this.tbBusquedaI.Name = "tbBusquedaI";
            this.tbBusquedaI.Size = new System.Drawing.Size(121, 20);
            this.tbBusquedaI.TabIndex = 1;
            this.tbBusquedaI.TextChanged += new System.EventHandler(this.tbBusquedaI_TextChanged);
            // 
            // btnAñadirCoche
            // 
            this.btnAñadirCoche.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAñadirCoche.Location = new System.Drawing.Point(446, 69);
            this.btnAñadirCoche.Name = "btnAñadirCoche";
            this.btnAñadirCoche.Size = new System.Drawing.Size(75, 48);
            this.btnAñadirCoche.TabIndex = 1;
            this.btnAñadirCoche.Text = "Cargar Nuevo Vehiculo";
            this.btnAñadirCoche.UseVisualStyleBackColor = false;
            this.btnAñadirCoche.Click += new System.EventHandler(this.btnAñadirCoche_Click);
            // 
            // btnModInquilino
            // 
            this.btnModInquilino.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModInquilino.Location = new System.Drawing.Point(446, 121);
            this.btnModInquilino.Name = "btnModInquilino";
            this.btnModInquilino.Size = new System.Drawing.Size(75, 37);
            this.btnModInquilino.TabIndex = 2;
            this.btnModInquilino.Text = "Modificar Inquilino";
            this.btnModInquilino.UseVisualStyleBackColor = false;
            this.btnModInquilino.Click += new System.EventHandler(this.btnModInquilino_Click);
            // 
            // pnlBusquedaV
            // 
            this.pnlBusquedaV.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlBusquedaV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBusquedaV.Controls.Add(this.cbBajasV);
            this.pnlBusquedaV.Controls.Add(this.label3);
            this.pnlBusquedaV.Controls.Add(this.label4);
            this.pnlBusquedaV.Controls.Add(this.label5);
            this.pnlBusquedaV.Controls.Add(this.cbFiltroV);
            this.pnlBusquedaV.Controls.Add(this.tbBusquedaV);
            this.pnlBusquedaV.Location = new System.Drawing.Point(539, 251);
            this.pnlBusquedaV.Name = "pnlBusquedaV";
            this.pnlBusquedaV.Size = new System.Drawing.Size(155, 191);
            this.pnlBusquedaV.TabIndex = 9;
            this.pnlBusquedaV.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBusquedaV_Paint);
            // 
            // cbBajasV
            // 
            this.cbBajasV.AutoSize = true;
            this.cbBajasV.Location = new System.Drawing.Point(16, 154);
            this.cbBajasV.Name = "cbBajasV";
            this.cbBajasV.Size = new System.Drawing.Size(113, 30);
            this.cbBajasV.TabIndex = 2;
            this.cbBajasV.Text = "Mostrar Vehiculos \r\nDados de baja\r\n";
            this.cbBajasV.UseVisualStyleBackColor = true;
            this.cbBajasV.CheckedChanged += new System.EventHandler(this.cbBajasV_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Buscar:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Filtar Por:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Busqueda Vehiculo:";
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
            this.cbFiltroV.Location = new System.Drawing.Point(16, 58);
            this.cbFiltroV.Name = "cbFiltroV";
            this.cbFiltroV.Size = new System.Drawing.Size(121, 21);
            this.cbFiltroV.TabIndex = 0;
            this.cbFiltroV.SelectedIndexChanged += new System.EventHandler(this.cbFiltroV_SelectedIndexChanged);
            // 
            // tbBusquedaV
            // 
            this.tbBusquedaV.Location = new System.Drawing.Point(16, 116);
            this.tbBusquedaV.Name = "tbBusquedaV";
            this.tbBusquedaV.Size = new System.Drawing.Size(121, 20);
            this.tbBusquedaV.TabIndex = 1;
            this.tbBusquedaV.TextChanged += new System.EventHandler(this.tbBusquedaV_TextChanged);
            // 
            // btnModificarV
            // 
            this.btnModificarV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModificarV.Location = new System.Drawing.Point(446, 257);
            this.btnModificarV.Name = "btnModificarV";
            this.btnModificarV.Size = new System.Drawing.Size(80, 40);
            this.btnModificarV.TabIndex = 5;
            this.btnModificarV.Text = "Modificar Vehiculo";
            this.btnModificarV.UseVisualStyleBackColor = false;
            this.btnModificarV.Click += new System.EventHandler(this.btnModificarV_Click);
            // 
            // btnEliminarV
            // 
            this.btnEliminarV.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarV.Location = new System.Drawing.Point(446, 349);
            this.btnEliminarV.Name = "btnEliminarV";
            this.btnEliminarV.Size = new System.Drawing.Size(80, 40);
            this.btnEliminarV.TabIndex = 6;
            this.btnEliminarV.Text = "Dar de Baja Vehiculo";
            this.btnEliminarV.UseVisualStyleBackColor = false;
            this.btnEliminarV.Click += new System.EventHandler(this.btnEliminarV_Click);
            // 
            // btnDarAlta
            // 
            this.btnDarAlta.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDarAlta.Enabled = false;
            this.btnDarAlta.Location = new System.Drawing.Point(446, 189);
            this.btnDarAlta.Name = "btnDarAlta";
            this.btnDarAlta.Size = new System.Drawing.Size(75, 23);
            this.btnDarAlta.TabIndex = 4;
            this.btnDarAlta.Text = "Dar de Alta";
            this.btnDarAlta.UseVisualStyleBackColor = false;
            this.btnDarAlta.Visible = false;
            this.btnDarAlta.Click += new System.EventHandler(this.btnDarAlta_Click);
            // 
            // btnAltaV
            // 
            this.btnAltaV.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAltaV.Location = new System.Drawing.Point(446, 395);
            this.btnAltaV.Name = "btnAltaV";
            this.btnAltaV.Size = new System.Drawing.Size(80, 40);
            this.btnAltaV.TabIndex = 7;
            this.btnAltaV.Text = "Dar de Alta";
            this.btnAltaV.UseVisualStyleBackColor = false;
            this.btnAltaV.Visible = false;
            this.btnAltaV.Click += new System.EventHandler(this.btnAltaV_Click);
            // 
            // btnCambiarDueño
            // 
            this.btnCambiarDueño.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCambiarDueño.Location = new System.Drawing.Point(446, 303);
            this.btnCambiarDueño.Name = "btnCambiarDueño";
            this.btnCambiarDueño.Size = new System.Drawing.Size(80, 40);
            this.btnCambiarDueño.TabIndex = 10;
            this.btnCambiarDueño.Text = "Cambiar Dueño";
            this.btnCambiarDueño.UseVisualStyleBackColor = false;
            this.btnCambiarDueño.Click += new System.EventHandler(this.btnCambiarDueño_Click);
            // 
            // FrmDueño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 453);
            this.Controls.Add(this.btnCambiarDueño);
            this.Controls.Add(this.btnAltaV);
            this.Controls.Add(this.btnDarAlta);
            this.Controls.Add(this.btnEliminarV);
            this.Controls.Add(this.btnModificarV);
            this.Controls.Add(this.pnlBusquedaV);
            this.Controls.Add(this.btnModInquilino);
            this.Controls.Add(this.btnAñadirCoche);
            this.Controls.Add(this.btnEliminarI);
            this.Controls.Add(this.btnNuevoInquilino);
            this.Controls.Add(this.pnlBusquedaInq);
            this.Controls.Add(this.dgvVehiculos);
            this.Controls.Add(this.dgvInquilinos);
            this.Name = "FrmDueño";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inquilinos y Vehiculos";
            this.Load += new System.EventHandler(this.FrmDueño_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInquilinos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.pnlBusquedaInq.ResumeLayout(false);
            this.pnlBusquedaInq.PerformLayout();
            this.pnlBusquedaV.ResumeLayout(false);
            this.pnlBusquedaV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInquilinos;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.Button btnEliminarI;
        private System.Windows.Forms.Button btnNuevoInquilino;
        private System.Windows.Forms.Panel pnlBusquedaInq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblbsq;
        private System.Windows.Forms.ComboBox cbFiltroI;
        private System.Windows.Forms.TextBox tbBusquedaI;
        private System.Windows.Forms.Button btnAñadirCoche;
        private System.Windows.Forms.Button btnModInquilino;
        private System.Windows.Forms.Panel pnlBusquedaV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFiltroV;
        private System.Windows.Forms.TextBox tbBusquedaV;
        private System.Windows.Forms.Button btnModificarV;
        private System.Windows.Forms.Button btnEliminarV;
        private System.Windows.Forms.CheckBox cbBajas;
        private System.Windows.Forms.Button btnDarAlta;
        private System.Windows.Forms.CheckBox cbBajasV;
        private System.Windows.Forms.Button btnAltaV;
        private System.Windows.Forms.Button btnCambiarDueño;
    }
}