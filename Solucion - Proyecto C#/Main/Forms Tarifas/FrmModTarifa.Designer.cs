namespace Main.Forms_Tarifas
{
    partial class FrmModTarifa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCargarTarifa = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAuto = new System.Windows.Forms.CheckBox();
            this.cbCamion = new System.Windows.Forms.CheckBox();
            this.cbMoto = new System.Windows.Forms.CheckBox();
            this.cbCamioneta = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipos Aplicables:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion";
            // 
            // btnCargarTarifa
            // 
            this.btnCargarTarifa.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCargarTarifa.Location = new System.Drawing.Point(67, 322);
            this.btnCargarTarifa.Name = "btnCargarTarifa";
            this.btnCargarTarifa.Size = new System.Drawing.Size(75, 23);
            this.btnCargarTarifa.TabIndex = 4;
            this.btnCargarTarifa.Text = "Modificar";
            this.btnCargarTarifa.UseVisualStyleBackColor = false;
            this.btnCargarTarifa.Click += new System.EventHandler(this.btnCargarTarifa_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(67, 37);
            this.tbNombre.MaxLength = 30;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(137, 20);
            this.tbNombre.TabIndex = 0;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(17, 263);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(187, 53);
            this.tbDescripcion.TabIndex = 3;
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(120, 200);
            this.nudPrecio.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(88, 20);
            this.nudPrecio.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "$";
            // 
            // cbAuto
            // 
            this.cbAuto.AutoSize = true;
            this.cbAuto.Location = new System.Drawing.Point(20, 14);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(48, 17);
            this.cbAuto.TabIndex = 14;
            this.cbAuto.Text = "Auto";
            this.cbAuto.UseVisualStyleBackColor = true;
            // 
            // cbCamion
            // 
            this.cbCamion.AutoSize = true;
            this.cbCamion.Location = new System.Drawing.Point(105, 37);
            this.cbCamion.Name = "cbCamion";
            this.cbCamion.Size = new System.Drawing.Size(61, 17);
            this.cbCamion.TabIndex = 15;
            this.cbCamion.Text = "Camion";
            this.cbCamion.UseVisualStyleBackColor = true;
            // 
            // cbMoto
            // 
            this.cbMoto.AutoSize = true;
            this.cbMoto.Location = new System.Drawing.Point(105, 14);
            this.cbMoto.Name = "cbMoto";
            this.cbMoto.Size = new System.Drawing.Size(50, 17);
            this.cbMoto.TabIndex = 16;
            this.cbMoto.Text = "Moto";
            this.cbMoto.UseVisualStyleBackColor = true;
            // 
            // cbCamioneta
            // 
            this.cbCamioneta.AutoSize = true;
            this.cbCamioneta.Location = new System.Drawing.Point(20, 37);
            this.cbCamioneta.Name = "cbCamioneta";
            this.cbCamioneta.Size = new System.Drawing.Size(76, 17);
            this.cbCamioneta.TabIndex = 17;
            this.cbCamioneta.Text = "Camioneta";
            this.cbCamioneta.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbMoto);
            this.panel1.Controls.Add(this.cbCamion);
            this.panel1.Controls.Add(this.cbCamioneta);
            this.panel1.Controls.Add(this.cbAuto);
            this.panel1.Location = new System.Drawing.Point(16, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 69);
            this.panel1.TabIndex = 1;
            // 
            // FrmModTarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 364);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btnCargarTarifa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmModTarifa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Tarifa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmModTarifa_FormClosed);
            this.Load += new System.EventHandler(this.FrmModTarifa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCargarTarifa;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbAuto;
        private System.Windows.Forms.CheckBox cbCamion;
        private System.Windows.Forms.CheckBox cbMoto;
        private System.Windows.Forms.CheckBox cbCamioneta;
        private System.Windows.Forms.Panel panel1;
    }
}