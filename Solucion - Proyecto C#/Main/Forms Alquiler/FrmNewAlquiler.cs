using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Main.Forms_Alquiler.Selecciones;
using MisClass;

namespace Main.Forms_Alquiler
{
    public partial class FrmNewAlquiler : Form
    {

        #region Formularios

        FrmSeleccionVehiculo oFrmV;
        FrmSeleccionLote oFrmL;
        FrmSeleccionTarifa oFrmT;


        #endregion

        #region Atributos

        public int idVeh = 0;
        public string patenteVeh = string.Empty;
        public string tipo = string.Empty;

        public int idLote = 0;
        public string nombreLote = string.Empty;


        public int idTar = 0;
        public string nombreTarifa = string.Empty;
        FrmAlquiler padre;

        clsAlquiler misAlquileres = new clsAlquiler("Alquileres", "C:\\Sistema de Cochera\\Alquileres");
     


        #endregion


        public FrmNewAlquiler(FrmAlquiler p)
        {
            padre = p;
            InitializeComponent();
        }

        private void FrmNewAlquiler_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            cbSalidaDefinida.Enabled = true;
            pnlTiempo.Enabled = true;
            dtpSalida.MinDate = DateTime.Today.AddDays(1);
            dtpSalida.Visible = false;
            cbPago.Visible = false;

            if (idVeh == 0)
            {
                btnTarf.Enabled = false;
                btnLote.Enabled = false;
            }
            else
            {
                btnTarf.Enabled = true;
                btnLote.Enabled = true;
            }

        }
                
        private void cbSalidaDefinida_CheckedChanged(object sender, EventArgs e)
        {
            dtpSalida.Visible = cbSalidaDefinida.Checked;
            lblMonto.Visible = cbSalidaDefinida.Checked;
            cbPago.Visible = cbSalidaDefinida.Checked;
            dtpSalida_ValueChanged(null, null);
            
        }
        
        private void btnVeh_Click(object sender, EventArgs e)
        {
            if (oFrmV == null || oFrmV.IsDisposed)
            {
                oFrmV = new FrmSeleccionVehiculo(this);
                oFrmV.Show();
            }
            else
            {
                oFrmV.Focus();
            }
        }        

        private void btnLote_Click(object sender, EventArgs e)
        {
            if (oFrmL == null || oFrmL.IsDisposed)
            {
                oFrmL = new FrmSeleccionLote(this,tipo);
                oFrmL.Show();
            }
            else
            {
                oFrmL.Focus();
            }

        }

        private void btnTarf_Click(object sender, EventArgs e)
        {

            if (oFrmT == null || oFrmT.IsDisposed)
            {
                oFrmT = new FrmSeleccionTarifa(this,tipo);
                oFrmT.Show();
            }
            else
            {
                oFrmT.Focus();
            }
        }
        
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            bool testeo=true;
            string errores = string.Empty;
            if (tbLote.Text == "<Sin Seleccionar>") {
               errores+="Seleccione un Lote\n";
                testeo = false;
                }
            if (tbVeh.Text == "<Sin Seleccionar>")
            {
                errores += "Seleccione un Vehiculo\n";
                testeo = false;
            }
            if (tbTarifa.Text == "<Sin Seleccionar>")
            {
                errores += "Seleccione una Tarifa para continuar \n";
                testeo = false;
            }


            if (testeo)
            {
                if (cbSalidaDefinida.Checked)
                {

                    misAlquileres.grabarAlquilerDias(idVeh, idTar, idLote, dtpSalida.Value,cbPago.Checked);

                    clsLote misLotes = new clsLote("Lotes", "C:\\Sistema de Cochera\\Lotes");

                    misLotes.setOcupado(this.idLote);

                    MessageBox.Show("Nuevo alquiler generado \n Patente:" + this.patenteVeh + "\n Lote:" + this.nombreLote + "\n Tarifa:" + this.nombreTarifa, "Alquiler Guardado!");

                    this.Close();
                }

                else
                {

                    misAlquileres.grabarAlquilerIndefinido(idVeh, idTar, idLote);

                    MessageBox.Show("Nuevo alquiler generado \n Patente:" + this.patenteVeh + "\n Lote:" + this.nombreLote + "\n Tarifa:" + this.nombreTarifa, "Alquiler Guardado!");

                    padre.setVistas();

                    this.Close();
                }
            }
            else {
                MessageBox.Show(errores, "Complete los siguientes datos");
            }
                
            }
        

        private void dtpSalida_ValueChanged(object sender, EventArgs e)
        {
            if (idTar != 0)
            {
                clsTarifa tar = new clsTarifa("Tarifas", "C:\\Sistema de Cochera\\Tarifas");
                tar = tar.existe(this.idTar);
                int dias = (int)(dtpSalida.Value - DateTime.Today).TotalDays;
                lblMonto.Text = "$" + (dias+1) * tar.Precio;
            }
        }



        public void actualizar()
        {



            if (patenteVeh != string.Empty)
            {
                tbVeh.Text = patenteVeh;
            }
            else
            {
                tbVeh.Text = "<Sin Seleccionar>";
            }

            if (nombreLote != string.Empty)
            {

                tbLote.Text = nombreLote;
            }
            else
            {
                tbLote.Text = "<Sin Seleccionar>";
            }
            if (nombreTarifa != string.Empty)
            {
                clsTarifa tar = new clsTarifa("Tarifas", "C:\\Sistema de Cochera\\Tarifas");
                tar = tar.existe(idTar);
                tbTarifa.Text = tar.Nombre;
                
            }
            else
            {
                tbTarifa.Text = "<Sin Seleccionar>";
            }


            if (idVeh == 0)
            {
                btnTarf.Enabled = false;
                btnLote.Enabled = false;
            }
            else {
                btnTarf.Enabled = true;
                btnLote.Enabled = true;
            }

        }

        private void FrmNewAlquiler_FormClosing(object sender, FormClosingEventArgs e)
        {
            padre.setVistas();
        }

        private void lblMonto_Click(object sender, EventArgs e)
        {

        }

        public void limpiarTarLot() {
            tbLote.Text = "<Sin Seleccionar>";
            tbTarifa.Text = "<Sin Seleccionar>";
        
        }


    }

}