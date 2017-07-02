namespace Main
{
    partial class FrmEstadisticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.rbTipos = new System.Windows.Forms.RadioButton();
            this.rbMonto = new System.Windows.Forms.RadioButton();
            this.cbDiaDeHoy = new System.Windows.Forms.CheckBox();
            this.nudAño = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAños = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.pnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMes
            // 
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "Todos",
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbMes.Location = new System.Drawing.Point(11, 63);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(121, 21);
            this.cbMes.TabIndex = 1;
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrar por Mes:";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(156, 21);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(548, 391);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlOpciones.Controls.Add(this.rbTipos);
            this.pnlOpciones.Controls.Add(this.rbMonto);
            this.pnlOpciones.Location = new System.Drawing.Point(12, 178);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(120, 111);
            this.pnlOpciones.TabIndex = 3;
            // 
            // rbTipos
            // 
            this.rbTipos.AutoSize = true;
            this.rbTipos.Location = new System.Drawing.Point(20, 60);
            this.rbTipos.Name = "rbTipos";
            this.rbTipos.Size = new System.Drawing.Size(51, 17);
            this.rbTipos.TabIndex = 1;
            this.rbTipos.Text = "Tipos";
            this.rbTipos.UseVisualStyleBackColor = true;
            this.rbTipos.AppearanceChanged += new System.EventHandler(this.rbMonto_CheckedChanged);
            // 
            // rbMonto
            // 
            this.rbMonto.AutoSize = true;
            this.rbMonto.Checked = true;
            this.rbMonto.Location = new System.Drawing.Point(20, 29);
            this.rbMonto.Name = "rbMonto";
            this.rbMonto.Size = new System.Drawing.Size(76, 17);
            this.rbMonto.TabIndex = 0;
            this.rbMonto.TabStop = true;
            this.rbMonto.Text = "Ganancias";
            this.rbMonto.UseVisualStyleBackColor = true;
            this.rbMonto.CheckedChanged += new System.EventHandler(this.rbMonto_CheckedChanged);
            // 
            // cbDiaDeHoy
            // 
            this.cbDiaDeHoy.AutoSize = true;
            this.cbDiaDeHoy.Location = new System.Drawing.Point(33, 12);
            this.cbDiaDeHoy.Name = "cbDiaDeHoy";
            this.cbDiaDeHoy.Size = new System.Drawing.Size(79, 17);
            this.cbDiaDeHoy.TabIndex = 0;
            this.cbDiaDeHoy.Text = "Dia de Hoy";
            this.cbDiaDeHoy.UseVisualStyleBackColor = true;
            this.cbDiaDeHoy.CheckedChanged += new System.EventHandler(this.cbDiaDeHoy_CheckedChanged);
            // 
            // nudAño
            // 
            this.nudAño.Location = new System.Drawing.Point(12, 112);
            this.nudAño.Maximum = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.nudAño.Minimum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.nudAño.Name = "nudAño";
            this.nudAño.Size = new System.Drawing.Size(120, 20);
            this.nudAño.TabIndex = 2;
            this.nudAño.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.nudAño.ValueChanged += new System.EventHandler(this.nudAño_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Año:";
            // 
            // cbAños
            // 
            this.cbAños.AutoSize = true;
            this.cbAños.Location = new System.Drawing.Point(16, 138);
            this.cbAños.Name = "cbAños";
            this.cbAños.Size = new System.Drawing.Size(99, 17);
            this.cbAños.TabIndex = 3;
            this.cbAños.Text = "Todos los Años";
            this.cbAños.UseVisualStyleBackColor = true;
            this.cbAños.CheckedChanged += new System.EventHandler(this.cbAños_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 377);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(101, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Recaudacion Total:";
            // 
            // FrmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 433);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cbAños);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudAño);
            this.Controls.Add(this.cbDiaDeHoy);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMes);
            this.Name = "FrmEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.FrmEstadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.RadioButton rbTipos;
        private System.Windows.Forms.RadioButton rbMonto;
        private System.Windows.Forms.CheckBox cbDiaDeHoy;
        private System.Windows.Forms.NumericUpDown nudAño;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbAños;
        private System.Windows.Forms.Label lblTotal;
    }
}