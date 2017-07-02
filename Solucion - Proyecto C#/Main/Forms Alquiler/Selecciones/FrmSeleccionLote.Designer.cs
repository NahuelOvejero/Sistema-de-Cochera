namespace Main.Forms_Alquiler.Selecciones
{
    partial class FrmSeleccionLote
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
            this.btnOK = new System.Windows.Forms.Button();
            this.dgvLotes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(104, 193);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 39);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Seleccionar";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dgvLotes
            // 
            this.dgvLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLotes.Location = new System.Drawing.Point(12, 19);
            this.dgvLotes.Name = "dgvLotes";
            this.dgvLotes.RowHeadersVisible = false;
            this.dgvLotes.Size = new System.Drawing.Size(272, 150);
            this.dgvLotes.TabIndex = 0;
            this.dgvLotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLotes_CellContentClick);
            // 
            // FrmSeleccionLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 251);
            this.Controls.Add(this.dgvLotes);
            this.Controls.Add(this.btnOK);
            this.Name = "FrmSeleccionLote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione un Lote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSeleccionLote_FormClosing);
            this.Load += new System.EventHandler(this.FrmSeleccionLote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView dgvLotes;
    }
}