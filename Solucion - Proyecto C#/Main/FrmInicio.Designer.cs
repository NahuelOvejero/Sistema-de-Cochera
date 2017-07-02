namespace Principal
{
    partial class FrmInicio
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
            this.components = new System.ComponentModel.Container();
            this.btnDueñosVehiculos = new System.Windows.Forms.Button();
            this.btnTarifas = new System.Windows.Forms.Button();
            this.btnLotes = new System.Windows.Forms.Button();
            this.btnAlquileres = new System.Windows.Forms.Button();
            this.dgvHoy = new System.Windows.Forms.DataGridView();
            this.lblAlqTotal = new System.Windows.Forms.Label();
            this.lblAlqActivos = new System.Windows.Forms.Label();
            this.lblVehiculos = new System.Windows.Forms.Label();
            this.lblDueños = new System.Windows.Forms.Label();
            this.lblDueñosActivos = new System.Windows.Forms.Label();
            this.lblVehAct = new System.Windows.Forms.Label();
            this.lblDiaDeHoy = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblReloj = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoy)).BeginInit();
            this.pnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDueñosVehiculos
            // 
            this.btnDueñosVehiculos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDueñosVehiculos.Location = new System.Drawing.Point(215, 20);
            this.btnDueñosVehiculos.Name = "btnDueñosVehiculos";
            this.btnDueñosVehiculos.Size = new System.Drawing.Size(140, 60);
            this.btnDueñosVehiculos.TabIndex = 1;
            this.btnDueñosVehiculos.Text = "Administrar Dueños y Vehiculos";
            this.btnDueñosVehiculos.UseVisualStyleBackColor = false;
            this.btnDueñosVehiculos.Click += new System.EventHandler(this.btnDueñosVehiculos_Click);
            // 
            // btnTarifas
            // 
            this.btnTarifas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTarifas.Location = new System.Drawing.Point(396, 20);
            this.btnTarifas.Name = "btnTarifas";
            this.btnTarifas.Size = new System.Drawing.Size(140, 60);
            this.btnTarifas.TabIndex = 2;
            this.btnTarifas.Text = "Administrar Tarifas";
            this.btnTarifas.UseVisualStyleBackColor = false;
            this.btnTarifas.Click += new System.EventHandler(this.btnTarifas_Click);
            // 
            // btnLotes
            // 
            this.btnLotes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLotes.Location = new System.Drawing.Point(577, 20);
            this.btnLotes.Name = "btnLotes";
            this.btnLotes.Size = new System.Drawing.Size(140, 60);
            this.btnLotes.TabIndex = 3;
            this.btnLotes.Text = "Lotes";
            this.btnLotes.UseVisualStyleBackColor = false;
            this.btnLotes.Click += new System.EventHandler(this.btnLotes_Click);
            // 
            // btnAlquileres
            // 
            this.btnAlquileres.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAlquileres.Location = new System.Drawing.Point(34, 20);
            this.btnAlquileres.Name = "btnAlquileres";
            this.btnAlquileres.Size = new System.Drawing.Size(140, 60);
            this.btnAlquileres.TabIndex = 0;
            this.btnAlquileres.Text = "Alquileres";
            this.btnAlquileres.UseVisualStyleBackColor = false;
            this.btnAlquileres.Click += new System.EventHandler(this.btnAlquileres_Click);
            // 
            // dgvHoy
            // 
            this.dgvHoy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoy.Location = new System.Drawing.Point(34, 212);
            this.dgvHoy.Name = "dgvHoy";
            this.dgvHoy.RowHeadersVisible = false;
            this.dgvHoy.Size = new System.Drawing.Size(606, 207);
            this.dgvHoy.TabIndex = 4;
            // 
            // lblAlqTotal
            // 
            this.lblAlqTotal.AutoSize = true;
            this.lblAlqTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlqTotal.Location = new System.Drawing.Point(214, 434);
            this.lblAlqTotal.Name = "lblAlqTotal";
            this.lblAlqTotal.Size = new System.Drawing.Size(116, 13);
            this.lblAlqTotal.TabIndex = 5;
            this.lblAlqTotal.Text = "Alquileres Totales: ";
            // 
            // lblAlqActivos
            // 
            this.lblAlqActivos.AutoSize = true;
            this.lblAlqActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlqActivos.Location = new System.Drawing.Point(435, 434);
            this.lblAlqActivos.Name = "lblAlqActivos";
            this.lblAlqActivos.Size = new System.Drawing.Size(116, 13);
            this.lblAlqActivos.TabIndex = 5;
            this.lblAlqActivos.Text = "Alquileres Activos: ";
            // 
            // lblVehiculos
            // 
            this.lblVehiculos.AutoSize = true;
            this.lblVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculos.Location = new System.Drawing.Point(214, 462);
            this.lblVehiculos.Name = "lblVehiculos";
            this.lblVehiculos.Size = new System.Drawing.Size(141, 13);
            this.lblVehiculos.TabIndex = 5;
            this.lblVehiculos.Text = "Vehiculos Registrados: ";
            // 
            // lblDueños
            // 
            this.lblDueños.AutoSize = true;
            this.lblDueños.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueños.Location = new System.Drawing.Point(214, 486);
            this.lblDueños.Name = "lblDueños";
            this.lblDueños.Size = new System.Drawing.Size(99, 13);
            this.lblDueños.TabIndex = 5;
            this.lblDueños.Text = "Socios Totales: ";
            // 
            // lblDueñosActivos
            // 
            this.lblDueñosActivos.AutoSize = true;
            this.lblDueñosActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueñosActivos.Location = new System.Drawing.Point(435, 486);
            this.lblDueñosActivos.Name = "lblDueñosActivos";
            this.lblDueñosActivos.Size = new System.Drawing.Size(99, 13);
            this.lblDueñosActivos.TabIndex = 5;
            this.lblDueñosActivos.Text = "Socios Activos: ";
            // 
            // lblVehAct
            // 
            this.lblVehAct.AutoSize = true;
            this.lblVehAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehAct.Location = new System.Drawing.Point(435, 462);
            this.lblVehAct.Name = "lblVehAct";
            this.lblVehAct.Size = new System.Drawing.Size(116, 13);
            this.lblVehAct.TabIndex = 5;
            this.lblVehAct.Text = "Vehiculos Activos: ";
            // 
            // lblDiaDeHoy
            // 
            this.lblDiaDeHoy.AutoSize = true;
            this.lblDiaDeHoy.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaDeHoy.Location = new System.Drawing.Point(214, 110);
            this.lblDiaDeHoy.Name = "lblDiaDeHoy";
            this.lblDiaDeHoy.Size = new System.Drawing.Size(0, 22);
            this.lblDiaDeHoy.TabIndex = 2;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.IndianRed;
            this.btnFinalizar.Location = new System.Drawing.Point(645, 288);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(72, 42);
            this.btnFinalizar.TabIndex = 0;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.Location = new System.Drawing.Point(668, 486);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(49, 13);
            this.lblReloj.TabIndex = 8;
            this.lblReloj.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEstadisticas.Location = new System.Drawing.Point(34, 434);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(78, 65);
            this.btnEstadisticas.TabIndex = 1;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // pnlFondo
            // 
            this.pnlFondo.Controls.Add(this.pictureBox3);
            this.pnlFondo.Controls.Add(this.btnFinalizar);
            this.pnlFondo.Controls.Add(this.btnEstadisticas);
            this.pnlFondo.Controls.Add(this.pictureBox5);
            this.pnlFondo.Controls.Add(this.dgvHoy);
            this.pnlFondo.Controls.Add(this.lblReloj);
            this.pnlFondo.Controls.Add(this.pictureBox4);
            this.pnlFondo.Controls.Add(this.pictureBox2);
            this.pnlFondo.Controls.Add(this.pictureBox1);
            this.pnlFondo.Controls.Add(this.lblAlqActivos);
            this.pnlFondo.Controls.Add(this.lblVehAct);
            this.pnlFondo.Controls.Add(this.lblDueñosActivos);
            this.pnlFondo.Controls.Add(this.lblVehiculos);
            this.pnlFondo.Controls.Add(this.lblDueños);
            this.pnlFondo.Controls.Add(this.lblAlqTotal);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(751, 519);
            this.pnlFondo.TabIndex = 10;
            this.pnlFondo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFondo_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Main.Properties.Resources.estadisticas;
            this.pictureBox3.Location = new System.Drawing.Point(118, 444);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Main.Properties.Resources.tarifas;
            this.pictureBox5.Location = new System.Drawing.Point(438, 86);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 43);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Main.Properties.Resources.lotes;
            this.pictureBox4.Location = new System.Drawing.Point(624, 86);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 43);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Main.Properties.Resources.dueños_y_autos;
            this.pictureBox2.Location = new System.Drawing.Point(257, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Main.Properties.Resources.alquileres;
            this.pictureBox1.Location = new System.Drawing.Point(79, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 519);
            this.Controls.Add(this.lblDiaDeHoy);
            this.Controls.Add(this.btnAlquileres);
            this.Controls.Add(this.btnLotes);
            this.Controls.Add(this.btnTarifas);
            this.Controls.Add(this.btnDueñosVehiculos);
            this.Controls.Add(this.pnlFondo);
            this.MaximizeBox = false;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Cochera - Nahuel Ovejero";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoy)).EndInit();
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDueñosVehiculos;
        private System.Windows.Forms.Button btnTarifas;
        private System.Windows.Forms.Button btnLotes;
        private System.Windows.Forms.Button btnAlquileres;
        private System.Windows.Forms.DataGridView dgvHoy;
        private System.Windows.Forms.Label lblAlqTotal;
        private System.Windows.Forms.Label lblAlqActivos;
        private System.Windows.Forms.Label lblVehiculos;
        private System.Windows.Forms.Label lblDueños;
        private System.Windows.Forms.Label lblDueñosActivos;
        private System.Windows.Forms.Label lblVehAct;
        private System.Windows.Forms.Label lblDiaDeHoy;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;


    }
}