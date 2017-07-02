using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MisClass;

namespace Main.Forms_Alquiler
{
    public partial class FrmAlquiler : Form
    {
        clsDueño misDueños;
        clsVehiculo misVehiculos;
        clsLote misLotes;
        clsTarifa misTarifas;
        clsAlquiler misAlquileres;
        clsConversor miConversor;
        clsFactura misFacturas;

        FrmNewAlquiler nFrmV;

        public FrmAlquiler(clsDueño dueño, clsVehiculo vehs, clsLote lotes, clsTarifa tarf, clsAlquiler alq)
        {

            misDueños = dueño;
            misVehiculos = vehs;
            misLotes = lotes;
            misTarifas = tarf;
            misAlquileres = alq;
            misFacturas = new clsFactura();
            miConversor = new clsConversor(alq,vehs, tarf, dueño, lotes);
            InitializeComponent();
            dgvAlquileres.ReadOnly = true;
            dgvAlquileres.RowHeadersVisible = false;
            dgvAlquileres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
             
        }

        private void FrmAlquiler_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            dgvAlquileres.RowHeadersVisible = false;
            setVistas();


            var provider = new System.Globalization.CultureInfo("es-AR");
            dgvAlquileres.Columns["Precio"].DefaultCellStyle.FormatProvider = provider;
            dgvAlquileres.Columns["Precio"].DefaultCellStyle.Format = "C";
            dgvAlquileres.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvAlquileres.Columns["Salida"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAlquileres.Columns["Entrada"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void btnNewAlquiler_Click(object sender, EventArgs e)
        {
            if (nFrmV == null || nFrmV.IsDisposed)
            {
                nFrmV = new FrmNewAlquiler(this);
                nFrmV.Show();
            }
            else
            {
                nFrmV.Focus();
            }
        }

        public void setVistas(){
            if (cbFinalizados.Checked)
            {
                dgvAlquileres.DataSource = miConversor.convertir(misAlquileres.listar());
                foreach (DataGridViewRow fila in dgvAlquileres.Rows) { 
                    bool estad = (bool)fila.Cells["Estado"].Value;
                    if(!estad){
                        fila.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
            else
            {
                dgvAlquileres.DataSource = miConversor.convertir(misAlquileres.listarAlta());
            }
            lblFecha.Text = "Hoy: " + DateTime.Today.ToLongDateString();
            dgvAlquileres.Columns["Estado"].Visible = false;
            dgvAlquileres.Columns["IdAlq"].Visible = false;
             foreach (DataGridViewRow fila in dgvAlquileres.Rows) {
                DateTime sal = (DateTime) fila.Cells["Salida"].Value;
                 bool estad = (bool)fila.Cells["Estado"].Value;
            if (sal<DateTime.Today && sal.Year != 0001 && estad)
            {
                fila.DefaultCellStyle.BackColor = Color.Brown;
            }

            if (sal == DateTime.Today) {
                fila.DefaultCellStyle.BackColor = Color.Green;
            }

             }

        }

        private void btnPago_Click(object sender, EventArgs e)
        {



            if (dgvAlquileres.SelectedRows.Count > 0)
            {

                DateTime salida = (DateTime)dgvAlquileres.SelectedRows[0].Cells["Salida"].Value;
                if (salida.Year == 1)
                {
                    MessageBox.Show("Solo podra marcar cómo pago un alquiler con salida indefinida, al finalizar el Alquiler. ", "Salida Indefinida");


                }
                else
                {
                    if (!(bool)dgvAlquileres.SelectedRows[0].Cells["Pago"].Value)
                    {
                        misAlquileres.marcarPago(Convert.ToInt32(dgvAlquileres.SelectedRows[0].Cells["IdAlq"].Value));
                        MessageBox.Show("Se marco como pago el alquiler del vehiculo \n Patente :" + dgvAlquileres.SelectedRows[0].Cells["Patente"].Value + "\n Dueño: " + dgvAlquileres.SelectedRows[0].Cells["Dueño"].Value, "Exito");
                        setVistas();
                    }
                    else
                    {
                        MessageBox.Show("Este Alquiler ya se encuentra registrado como pago.", "Alquiler ya pago");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione el alquiler que desee marcar pago.", "Seleccione un Alquiler");
            }
        }

        

        private void btnHoy_Click(object sender, EventArgs e)
        {
            if (btnHoy.Tag.ToString().Equals("hoy")) 
            {
                dgvAlquileres.DataSource = miConversor.convertir(misAlquileres.listarHOY());
                btnHoy.Text = "Mostrar Todos los Alquileres";
                btnHoy.Tag = "todo";
            }
            else{
               btnHoy.Text = "Mostrar Alquileres con salida Hoy";
               setVistas();
               btnHoy.Tag = "hoy";
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (dgvAlquileres.SelectedRows.Count > 0)
            {
                DateTime salida = (DateTime)dgvAlquileres.SelectedRows[0].Cells["Salida"].Value;
                DateTime entrada = (DateTime)dgvAlquileres.SelectedRows[0].Cells["Entrada"].Value;
                
                bool pago = (bool)dgvAlquileres.SelectedRows[0].Cells["Pago"].Value;
                double costo = Convert.ToDouble(dgvAlquileres.SelectedRows[0].Cells["Precio"].Value);


                if (salida != DateTime.Today)
                {
                    double totales;
                    double parcial;
                    if (salida.Year != 1)
                        totales = 1+(salida - entrada).TotalDays;
                    else
                        totales = 1+(DateTime.Today - entrada).TotalDays;
                    if (totales != 0)
                        parcial = costo / totales;
                    else
                        parcial = 0;
                    string msj;
                    if (salida.Year != 1)
                    {
                        if (salida > DateTime.Today)
                        {
                            int dias = (int)(DateTime.Today - entrada).TotalDays;
                            dias++;//por si se cobra el dia de entrada, a criterio.
                            msj = " El alquiler tiene fecha de salida: " + salida.ToShortDateString();
                            if (!pago)
                            {
                                msj += "\n Finalizar el alquiler ahora, tendra un costo de: $" + parcial * dias;
                                msj += "\n Desea marcar pago y finalizar el alquiler?";
                                costo = parcial * dias;
                            }
                            else
                            {
                                double vuelto = costo - (parcial*dias);
                                msj += "\n El alquiler ya se encuentra pago.";
                                msj += "\n El vuelto sera de : $" + vuelto;
                                msj += "\n  Desea finalizar el alquiler?";
                                costo-=vuelto;
                            }
                        }
                        else {
                            int n = (int)(DateTime.Today - entrada).TotalDays;
                            msj = "El alquiler tiene fecha de salida: " + salida.ToShortDateString();
                            msj += "\n Tiene una recargo de " + n + " dias";
                            double diferencia = n * parcial;
                            if (!pago)
                            {
                                msj+="Debera abonar un total de: $" + (costo+diferencia);
                                costo+= diferencia;
                            }
                            else
                            {
                                msj += "Teniendo pago lo estipulado, debera pagar un recargo de: $" + diferencia;
                                costo+= diferencia;
                            }
                        }
                    }
                    else
                    {
                        msj = "El alquiler indefinido con entrada :" + entrada.ToShortDateString() +
                         "\n tendra un costo de :$" + costo;

                        msj += "\n   Desea marcar pago y finalizar el alquiler?";

                    }


                    DialogResult result = MessageBox.Show(msj, "Finalizar Alquiler Antes", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        //Baja alquiler
                        int IdAlq = (int)dgvAlquileres.SelectedRows[0].Cells["IdAlq"].Value;
                        misAlquileres.marcarPago(IdAlq);
                        misAlquileres.darBaja(IdAlq);
                        MessageBox.Show("Ha finalizado el alquiler.", "Operacion Exitosa");

                        string nombre = dgvAlquileres.SelectedRows[0].Cells["Dueño"].Value.ToString();
                        string tipo = misVehiculos.existe(dgvAlquileres.SelectedRows[0].Cells["Patente"].Value.ToString()).Tipo;

                        misFacturas.GrabarFactura(DateTime.Today, Convert.ToDecimal(costo),nombre,tipo);

                        setVistas();

                    }
                    else
                    {
                        //Salvado
                        MessageBox.Show("El estado del Alquiler no ha cambiado", "Operacion Cancelada");
                    }




                }
                //fin de if no es fecha hoy

                else
                {
                    string msj;
                    
                    if (!pago)
                        msj = "Desea marcar como pago y finalizar el alquiler?";
                    else
                        msj = "El alquiler ya esta pago. \n desea finalizar el alquiler?";

                    DialogResult result = MessageBox.Show(msj, "Finalizar Alquiler", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        //Baja alquiler
                        int IdAlq = (int)dgvAlquileres.SelectedRows[0].Cells["IdAlq"].Value;
                        misAlquileres.marcarPago(IdAlq);
                        misAlquileres.darBaja(IdAlq);

                        MessageBox.Show("Ha finalizado el alquiler.", "Operacion Exitosa");
                        string nombre = dgvAlquileres.SelectedRows[0].Cells["Dueño"].Value.ToString();
                        string tipo = misVehiculos.existe(dgvAlquileres.SelectedRows[0].Cells["Dueño"].Value.ToString()).Tipo;

                        misFacturas.GrabarFactura(DateTime.Today, Convert.ToDecimal(costo), nombre, tipo);

                        setVistas();

                    }
                    else
                    {
                        //Salvado
                        MessageBox.Show("El estado del Alquiler no ha cambiado", "Operacion Cancelada");
                    }


                }
            }

            else
            {
                MessageBox.Show("Seleccione el alquiler para finalizar", "Seleccione un Alquiler");
            }

        }

        private void cbFinalizados_CheckedChanged(object sender, EventArgs e)
        {
            setVistas();
        }









    }
}
