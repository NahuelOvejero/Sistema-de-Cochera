using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MisClass;
using System.Globalization;

namespace Main
{
    public partial class FrmEstadisticas : Form
    {
        clsFactura misFacturas = new clsFactura();
        int FacturasTotales;
        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false; 
            
            lblTotal.Text = "Recaudacion Total: $" + misFacturas.total();
            nudAño.Maximum = DateTime.Today.Year;
            nudAño.Value = DateTime.Today.Year;
            cbMes.SelectedIndex = 0;
            cbDiaDeHoy.Checked = true;
            FacturasTotales = misFacturas.listarFacturas().Count;
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDiaDeHoy.Checked = false;
            int año = Convert.ToInt32(nudAño.Value);
           if (cbAños.Checked)
                {
                    generarChart();
                }
           else
           {
               generarChart();
            }

        }




        public void generarChart()
        {
            decimal monto;
            int añoSeleccionado = (int)nudAño.Value;
            chart1.Series.Clear();

            #region ganancia
            if (rbMonto.Checked)
            {
                chart1.Series.Add("Dinero");
                chart1.Series["Dinero"].IsValueShownAsLabel = true;
                chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

                //PARA EL DIA DE HOY
                if (cbDiaDeHoy.Checked)
                {

                    foreach (var series in chart1.Series)
                    {
                        series.Points.Clear();
                    }

                    monto = misFacturas.montoTotalDia(DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);

                    chart1.Series["Dinero"].Points.AddXY("Hoy:" + DateTime.Today.ToShortDateString(), monto);

                    if (monto < 0) {
                        MessageBox.Show("Los archivos del sistema fueron eliminados durante el proceso" + Environment.NewLine + "Intente reiniciando el sistema.", "Error Inesperado");
                    }

                }
                else
                    //SI TODOS LOS MESES ESTA SELECCIONADO
                    if (cbMes.SelectedIndex == 0)
                    {

                        foreach (var series in chart1.Series)
                        {
                            series.Points.Clear();
                        }

                        //SI DESEA DE TODOS LOS AÑOS
                        if (cbAños.Checked)
                        {

                            for (int i = 0; i < 13; i++)
                            {
                                monto = misFacturas.montoTotalMes(i, 0);
                                if (monto > 0)
                                {
                                    chart1.Series["Dinero"].Points.AddXY(i, monto);
                                }
                            }


                        }

                        else
                        {
                            foreach (var series in chart1.Series)
                            {
                                series.Points.Clear();
                            }


                            //SI DESEA PARA UN AÑO ESPECIFICO
                            for (int i = 1; i < 13; i++)
                            {
                                monto = misFacturas.montoTotalMes(i, añoSeleccionado);
                                if (monto > 0)
                                {
                                    chart1.Series["Dinero"].Points.AddXY(i, monto);
                                }
                            }


                        }
                    }
                    //codigo para el mes seleccionado
                    else
                    {

                        if (cbAños.Checked)
                        {

                            foreach (var series in chart1.Series)
                            {
                                series.Points.Clear();
                            }


                            for (int i = 1; i < 13; i++)
                            {
                                monto = misFacturas.montoTotalDia(i, cbMes.SelectedIndex, 0);
                                if (monto > 0)
                                {
                                    chart1.Series["Dinero"].Points.AddXY(i, monto);
                                }
                            }
                        }
                        else
                        {
                            foreach (var series in chart1.Series)
                            {
                                series.Points.Clear();
                            }

                            for (int i = 1; i < 32; i++)
                            {
                                monto = misFacturas.montoTotalDia(i, cbMes.SelectedIndex, añoSeleccionado);
                                if (monto > 0)
                                {
                                    chart1.Series["Dinero"].Points.AddXY(i, monto);
                                }
                            }
                        }

                    }
            }

            #endregion

            #region tipos
            if (rbTipos.Checked)
            {

                chart1.Series.Add("Tipos");                
                chart1.Series["Tipos"].IsValueShownAsLabel = true;
                chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                if (cbDiaDeHoy.Checked)
                {

                    foreach (var series in chart1.Series)
                    {
                        series.Points.Clear();
                    }

                    int auto = 0;
                    int moto = 0;
                    int camioneta = 0;
                    int camion = 0;

                    foreach (clsFactura f in misFacturas.listarFacturas(DateTime.Today))
                    {
                        if (f.Tipo.Equals("Auto"))
                            auto++;
                        if (f.Tipo.Equals("Camion"))
                            camion++;
                        if (f.Tipo.Equals("Camioneta"))
                            camioneta++;
                        if (f.Tipo.Equals("Moto"))
                            moto++;
                    }
                    chart1.Series["Tipos"].Points.AddXY("Auto", auto);
                    chart1.Series["Tipos"].Points.AddXY("Moto", moto);
                    chart1.Series["Tipos"].Points.AddXY("Camioneta", camioneta);
                    chart1.Series["Tipos"].Points.AddXY("Camion", camion);
                }



                else
                    if (cbMes.SelectedIndex == 0)
                    {
                        //si estan marcados todos

                        foreach (var series in chart1.Series)
                        {
                            series.Points.Clear();
                        }

                        int auto = 0;
                        int moto = 0;
                        int camioneta = 0;
                        int camion = 0;
                        for (int i = 1; i < 13; i++)
                        {

                            auto += misFacturas.tipoTotalMes(i, añoSeleccionado, "Auto");
                            moto += misFacturas.tipoTotalMes(i, añoSeleccionado, "Moto");
                            camioneta += misFacturas.tipoTotalMes(i, añoSeleccionado, "Camioneta");
                            camion += misFacturas.tipoTotalMes(i, añoSeleccionado, "Camion");
                        }

                        if (auto > 0)
                        {

                            chart1.Series["Tipos"].Points.AddXY("Auto", auto);
                        }
                        if (moto > 0)
                        {
                            chart1.Series["Tipos"].Points.AddXY("Moto", moto);
                        }
                        if (camioneta > 0)
                        {
                            chart1.Series["Tipos"].Points.AddXY("Camioneta", camioneta);
                        }
                        if (camion > 0)
                        {
                            chart1.Series["Tipos"].Points.AddXY("Camion", camion);
                        }



                    }

                    else
                    {


                        foreach (var series in chart1.Series)
                        {
                            series.Points.Clear();
                        }

                        int auto = 0;
                        int moto = 0;
                        int camioneta = 0;
                        int camion = 0;



                        auto += misFacturas.tipoTotalMes(cbMes.SelectedIndex, añoSeleccionado, "Auto");
                        moto += misFacturas.tipoTotalMes(cbMes.SelectedIndex, añoSeleccionado, "Moto");
                        camioneta += misFacturas.tipoTotalMes(cbMes.SelectedIndex, añoSeleccionado, "Camioneta");
                        camion += misFacturas.tipoTotalMes(cbMes.SelectedIndex, añoSeleccionado, "Camion");
                        

                        if (auto > 0)
                        {

                            chart1.Series["Tipos"].Points.AddXY("Auto", auto);
                        }
                        if (moto > 0)
                        {
                            chart1.Series["Tipos"].Points.AddXY("Moto", moto);
                        }
                        if (camioneta > 0)
                        {
                            chart1.Series["Tipos"].Points.AddXY("Camioneta", camioneta);
                        }
                        if (camion > 0)
                        {
                            chart1.Series["Tipos"].Points.AddXY("Camion", camion);
                        }
                    }
            }

            #endregion

        }


        private void cbDiaDeHoy_CheckedChanged(object sender, EventArgs e)
        {

            cbAños.Enabled = !cbDiaDeHoy.Checked;
            nudAño.Enabled = !cbDiaDeHoy.Checked;


            if (cbDiaDeHoy.Checked) {
                generarChart();
            }
            else{
                cambioAño();
            }
        }

        private void cbAños_CheckedChanged(object sender, EventArgs e)
        {
            nudAño.Enabled = !cbAños.Checked;
            if (cbAños.Checked)
            {
                generarChart();
            }
            else
            {
                generarChart();
            }
            generarChart();  
        }

        private void nudAño_ValueChanged(object sender, EventArgs e)
        {
            generarChart();
        }

        private void rbMonto_CheckedChanged(object sender, EventArgs e)
        {
            generarChart();
        }


        private void cambioAño() {

            generarChart();
        }



        


    }
}
