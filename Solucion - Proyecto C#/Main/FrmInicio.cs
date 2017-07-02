using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MisClass;
using Main;
using Main.Forms_Tarifas;
using Main.Forms_Lote;
using Main.Forms_Alquiler;

namespace Principal
{
    public partial class FrmInicio : Form
    {
        FrmDueño ofrmDueño;
        FrmMainTarifa ofrmTarifas;
        FrmLotes oFrmLote;
        FrmAlquiler oFrmAlquiler;
        FrmEstadisticas oFrmEstadisticas;

        clsDueño misDueños;
        clsVehiculo misVehiculos;
        clsTarifa misTarifas;
        clsLote misLotes;
        clsAlquiler misAlquileres;
        clsFactura misFacturas;

        clsConversor miConversor;

        public FrmInicio()
        {
            InitializeComponent();
        }




        private void FrmInicio_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            //CONSTRUIR ó BUSCAR archivos
            misDueños = new clsDueño("Inquilinos","C:\\Sistema de Cochera\\Inquilinos");
            misVehiculos = new clsVehiculo("Vehiculos","C:\\Sistema de Cochera\\Vehiculos");
            misTarifas = new clsTarifa("Tarifas", "C:\\Sistema de Cochera\\Tarifas");
            misLotes = new clsLote("Lotes", "C:\\Sistema de Cochera\\Lotes");
            misAlquileres = new clsAlquiler("Alquileres", "C:\\Sistema de Cochera\\Alquileres");
            misFacturas = new clsFactura("Facturas", "C:\\Sistema de Cochera\\Facturas");
            //genera el conversor
            miConversor = new clsConversor(misAlquileres, misVehiculos, misTarifas, misDueños, misLotes);
            //configura grilla:
            setVistas();

        }



        public void setVistas() {

                dgvHoy.DataSource = miConversor.convertir(misAlquileres.listarHOY());
                dgvHoy.Columns[0].Visible = false; //id
                dgvHoy.Columns[8].Visible = false; //Estado
                dgvHoy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvHoy.MultiSelect = false;

                dgvHoy.Columns["Pago"].ReadOnly = true;

            //muestra datos
        }

        public void actDatos()
        {
            lblAlqActivos.Text = "Alquileres Activos : " + misAlquileres.listarAlta().Count;
            lblAlqTotal.Text = "Alquileres totales : " + misAlquileres.listar().Count;

            lblVehiculos.Text = "Vehiculos totales : " + misVehiculos.listar().Count;
            lblVehAct.Text = "Vehiculos activos : " + misVehiculos.listarAlta().Count;

            lblDueños.Text = "Dueños totales: " + misDueños.listar().Count;
            lblDueñosActivos.Text = "Dueños Activos : " + misDueños.listarAlta().Count;
            //carga fecha
            lblDiaDeHoy.Text = "Salidas para el dia de Hoy : " + DateTime.Today.ToShortDateString();
            lblDiaDeHoy.Location = new Point(175, 170);
        }

        private void btnDueñosVehiculos_Click(object sender, EventArgs e)
        {
            if (ofrmDueño == null || ofrmDueño.IsDisposed)
            {
                ofrmDueño = new FrmDueño(misDueños, misVehiculos);
                ofrmDueño.Show();
            }
            else
            {
                ofrmDueño.Focus();
            }
        }

        private void btnTarifas_Click(object sender, EventArgs e)
        {
            if (ofrmTarifas == null || ofrmTarifas.IsDisposed)
            {
                ofrmTarifas = new FrmMainTarifa(misTarifas);
                ofrmTarifas.Show();
            }
            else
            {
                ofrmTarifas.Focus();
            }

        }

        private void btnLotes_Click(object sender, EventArgs e)
        {

            if (oFrmLote == null || oFrmLote.IsDisposed)
            {
                oFrmLote = new FrmLotes(misLotes);
                oFrmLote.Show();
            }
            else
            {
                oFrmLote.Focus();
            }
        }

        private void btnAlquileres_Click(object sender, EventArgs e)
        {
            if (oFrmAlquiler == null || oFrmAlquiler.IsDisposed)
            {
                oFrmAlquiler = new FrmAlquiler(misDueños,misVehiculos,misLotes,misTarifas,misAlquileres);
                oFrmAlquiler.Show();
            }
            else
            {
                oFrmAlquiler.Focus();
            }


        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (dgvHoy.SelectedRows.Count > 0) {
                string msj;
                bool pago  = (bool)dgvHoy.SelectedRows[0].Cells["Pago"].Value;
                if (!pago)
                    msj = "Desea marcar como pago y finalizar el alquiler?";
                else
                    msj = "El alquiler ya esta pago. \n desea finalizar el alquiler?";

                DialogResult result = MessageBox.Show(msj, "Finalizar Alquiler", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string excepcion = string.Empty;
                    //Baja alquiler
                    int IdAlq = (int)dgvHoy.SelectedRows[0].Cells["IdAlq"].Value;
                    try
                    {
                        excepcion = misAlquileres.marcarPago(IdAlq);
                        excepcion = misAlquileres.darBaja(IdAlq);
                        MessageBox.Show("Ha finalizado el alquiler.", "Operacion Exitosa");


                        decimal costo = (decimal)dgvHoy.SelectedRows[0].Cells["Precio"].Value;

                        string nombre = dgvHoy.SelectedRows[0].Cells["Dueño"].Value.ToString();
                        string tipo = misVehiculos.existe(dgvHoy.SelectedRows[0].Cells["Patente"].Value.ToString()).Tipo;

                        excepcion = misFacturas.GrabarFactura(DateTime.Today, Convert.ToDecimal(costo), nombre, tipo);
                    }

                    catch (Exception ex) {
                        MessageBox.Show(excepcion, "Se ha producido el siguiente error:");
                    }

                    setVistas();

                }
                else
                {
                    //Salvado
                    MessageBox.Show("El estado del Alquiler no ha cambiado", "Operacion Cancelada");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            actDatos();
            lblReloj.Text = DateTime.Now.ToString("h:mm:ss tt");
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            if (oFrmEstadisticas == null || oFrmEstadisticas.IsDisposed)
            {
                oFrmEstadisticas = new FrmEstadisticas();
                oFrmEstadisticas.Show();
            }
            else
            {
                oFrmEstadisticas.Focus();
            }
        }

        private void pnlFondo_Paint(object sender, PaintEventArgs e)
        {

        }

     

       



     

 
    }
}
