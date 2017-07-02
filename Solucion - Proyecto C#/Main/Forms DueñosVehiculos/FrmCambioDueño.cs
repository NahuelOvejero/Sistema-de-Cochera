using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Main;
using MisClass;
using Principal;


namespace Main
{
    public partial class FrmCambioDueño : Form
    {
        clsDueño dueños = new clsDueño("Inquilinos", "C:\\Sistema de Cochera\\Inquilinos");
        clsVehiculo misV = new clsVehiculo("Vehiculos", "C:\\Sistema de Cochera\\Vehiculos");
        clsVehiculo aux;
        FrmDueño pa;
        public FrmCambioDueño(clsVehiculo cambio, FrmDueño padre)
        {
            aux = cambio;
            pa = padre;
            InitializeComponent();


            if (dueños.listarAlta() != null)
            {
                dgvInq.DataSource = dueños.listarAlta();

                //oculto columna Estado y columna Id - Atributos Heredados
                dgvInq.Columns[0].Visible = false;
                dgvInq.Columns[1].Visible = false;
                dgvInq.Columns[6].Visible = false;
                dgvInq.Columns[7].Visible = false;
                dgvInq.Columns[8].Visible = false;
                dgvInq.Columns[9].Visible = false;

            }

            else {
                MessageBox.Show("No hay inquilinos que mostrar", "Informacion no disponible");
                }
        }

        private void FrmCambioDueño_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            lblDatoV.Text = "Modificando el dueño de: " + aux.Tipo + "Patente: " + aux.Patente;
            lblDatoV.TextAlign = ContentAlignment.MiddleCenter;
            
        }



        private void FrmCambioDueño_FormClosed(object sender, FormClosedEventArgs e)
        {
            pa.recargarVistas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCambioDueño_Click(object sender, EventArgs e)
        {
            if (dgvInq.SelectedRows.Count < 1)
            {
                MessageBox.Show("Seleccione el nuevo dueño", "Error");
            }
            else {
                int idDueño = Convert.ToInt32(dgvInq.SelectedRows[0].Cells["Id"].Value);
                MessageBox.Show("Estado: " + misV.cambiarDueño(idDueño, aux.Id), "Resultado!");
                this.Close();
                }
        }

 


    }
}
