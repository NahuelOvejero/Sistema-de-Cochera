namespace Main.Forms_Alquiler
{
    partial class FrmAlquiler
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
            this.dgvAlquileres = new System.Windows.Forms.DataGridView();
            this.btnNewAlquiler = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnHoy = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnPago = new System.Windows.Forms.Button();
            this.cbFinalizados = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlquileres
            // 
            this.dgvAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlquileres.Location = new System.Drawing.Point(12, 28);
            this.dgvAlquileres.Name = "dgvAlquileres";
            this.dgvAlquileres.Size = new System.Drawing.Size(684, 282);
            this.dgvAlquileres.TabIndex = 0;
            // 
            // btnNewAlquiler
            // 
            this.btnNewAlquiler.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNewAlquiler.Location = new System.Drawing.Point(702, 28);
            this.btnNewAlquiler.Name = "btnNewAlquiler";
            this.btnNewAlquiler.Size = new System.Drawing.Size(78, 40);
            this.btnNewAlquiler.TabIndex = 1;
            this.btnNewAlquiler.Text = "Nuevo Alquiler";
            this.btnNewAlquiler.UseVisualStyleBackColor = false;
            this.btnNewAlquiler.Click += new System.EventHandler(this.btnNewAlquiler_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.IndianRed;
            this.btnFinalizar.Location = new System.Drawing.Point(702, 206);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(78, 40);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar Alquiler";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnHoy
            // 
            this.btnHoy.Location = new System.Drawing.Point(702, 132);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Size = new System.Drawing.Size(78, 63);
            this.btnHoy.TabIndex = 3;
            this.btnHoy.Tag = "hoy";
            this.btnHoy.Text = "Alquileres con Salida Hoy";
            this.btnHoy.UseVisualStyleBackColor = true;
            this.btnHoy.Click += new System.EventHandler(this.btnHoy_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(313, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 13);
            this.lblFecha.TabIndex = 4;
            // 
            // btnPago
            // 
            this.btnPago.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPago.Location = new System.Drawing.Point(702, 79);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(78, 42);
            this.btnPago.TabIndex = 2;
            this.btnPago.Text = "Marcar Pago";
            this.btnPago.UseVisualStyleBackColor = false;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // cbFinalizados
            // 
            this.cbFinalizados.AutoSize = true;
            this.cbFinalizados.Location = new System.Drawing.Point(702, 267);
            this.cbFinalizados.Name = "cbFinalizados";
            this.cbFinalizados.Size = new System.Drawing.Size(78, 43);
            this.cbFinalizados.TabIndex = 5;
            this.cbFinalizados.Text = "Mostrar \r\nAlquileres\r\nFinalizados";
            this.cbFinalizados.UseVisualStyleBackColor = true;
            this.cbFinalizados.CheckedChanged += new System.EventHandler(this.cbFinalizados_CheckedChanged);
            // 
            // FrmAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 343);
            this.Controls.Add(this.cbFinalizados);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnHoy);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnNewAlquiler);
            this.Controls.Add(this.dgvAlquileres);
            this.Name = "FrmAlquiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alquileres";
            this.Load += new System.EventHandler(this.FrmAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlquileres;
        private System.Windows.Forms.Button btnNewAlquiler;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnHoy;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.CheckBox cbFinalizados;
    }
}