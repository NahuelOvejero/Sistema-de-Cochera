namespace Main
{
    partial class FrmCambioDueño
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
            this.dgvInq = new System.Windows.Forms.DataGridView();
            this.btnCambioDueño = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDatoV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInq)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInq
            // 
            this.dgvInq.AllowUserToAddRows = false;
            this.dgvInq.AllowUserToDeleteRows = false;
            this.dgvInq.AllowUserToResizeColumns = false;
            this.dgvInq.AllowUserToResizeRows = false;
            this.dgvInq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInq.Location = new System.Drawing.Point(13, 73);
            this.dgvInq.MultiSelect = false;
            this.dgvInq.Name = "dgvInq";
            this.dgvInq.ReadOnly = true;
            this.dgvInq.RowHeadersVisible = false;
            this.dgvInq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInq.Size = new System.Drawing.Size(400, 150);
            this.dgvInq.TabIndex = 0;
            // 
            // btnCambioDueño
            // 
            this.btnCambioDueño.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCambioDueño.Location = new System.Drawing.Point(114, 240);
            this.btnCambioDueño.Name = "btnCambioDueño";
            this.btnCambioDueño.Size = new System.Drawing.Size(95, 38);
            this.btnCambioDueño.TabIndex = 1;
            this.btnCambioDueño.Text = "Seleccionar Dueño";
            this.btnCambioDueño.UseVisualStyleBackColor = false;
            this.btnCambioDueño.Click += new System.EventHandler(this.btnCambioDueño_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.Location = new System.Drawing.Point(250, 240);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 38);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblDatoV
            // 
            this.lblDatoV.AutoSize = true;
            this.lblDatoV.Location = new System.Drawing.Point(12, 32);
            this.lblDatoV.Name = "lblDatoV";
            this.lblDatoV.Size = new System.Drawing.Size(25, 13);
            this.lblDatoV.TabIndex = 3;
            this.lblDatoV.Text = "Info";
            this.lblDatoV.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmCambioDueño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 304);
            this.Controls.Add(this.lblDatoV);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCambioDueño);
            this.Controls.Add(this.dgvInq);
            this.Name = "FrmCambioDueño";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione un Nuevo Dueño";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCambioDueño_FormClosed);
            this.Load += new System.EventHandler(this.FrmCambioDueño_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInq;
        private System.Windows.Forms.Button btnCambioDueño;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDatoV;
    }
}