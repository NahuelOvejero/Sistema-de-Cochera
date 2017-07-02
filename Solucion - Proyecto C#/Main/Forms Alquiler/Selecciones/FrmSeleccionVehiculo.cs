using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MisClass;

namespace Main.Forms_Alquiler.Selecciones
{
    public partial class FrmSeleccionVehiculo : Form
    {

        #region atributos
        FrmNewAlquiler padre;
        bool confirmado = false;
        clsVehiculo misVehiculos = new clsVehiculo("Vehiculos", "C:\\Sistema de Cochera\\Vehiculos");
        clsAlquiler misAlquileres = new clsAlquiler("Alquileres", "C:\\Sistema de Cochera\\Alquileres");
        #endregion


        public FrmSeleccionVehiculo(FrmNewAlquiler p)
        {
            padre = p;
            InitializeComponent();
        }

        private void frmSeleccionVehiculo_Load(object sender, EventArgs e)
        {
            cbFiltroV.SelectedIndex = 0;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            dgvVehiculo.ReadOnly = true;
            dgvVehiculo.DataSource = misVehiculos.listarAlta();
            dgvVehiculo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (dgvVehiculo.Rows.Count > 0)
            {

                dgvVehiculo.Columns[0].Visible = false; //ID
                dgvVehiculo.Columns[1].Visible = false; //ID dueño
                dgvVehiculo.Columns[7].Visible = false;
                dgvVehiculo.Columns[8].Visible = false;
                dgvVehiculo.Columns[9].Visible = false;
                dgvVehiculo.Columns[10].Visible = false;
                dgvVehiculo.Columns[11].Visible = false;

                dgvVehiculo.Columns["Patente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgvVehiculo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                btnOk.Enabled = filtrado();
            }
            else
            {
                MessageBox.Show("No hay Vehiculos Libres Disponibles");
                this.Close();
            }


        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            confirmado = true;
            this.Close();
        }

        private void FrmSeleccionVehiculo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (confirmado)
            {
                try
                {
                    padre.idVeh = (int)dgvVehiculo.SelectedRows[0].Cells[0].Value;
                    padre.patenteVeh = dgvVehiculo.SelectedRows[0].Cells["Patente"].Value.ToString();
                    padre.tipo = dgvVehiculo.SelectedRows[0].Cells["Tipo"].Value.ToString();
                    padre.actualizar();
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message + ". Debe seleccionar un Vehiculo para continuar", "Seleccione un Vehiculo");
                }
                finally {
                    padre.limpiarTarLot();
                }
            }
        }


        public bool filtrado()
        {
            //Si ya esta asignado a un alquiler. No se puede asignar el mismo vehiculo a 2 alquileres a la vez.
            int visibles = 0;
            foreach (DataGridViewRow fila in dgvVehiculo.Rows)
            {
                if (misAlquileres.enUso(Convert.ToInt32(fila.Cells["Id"].Value)))
                {
                    fila.Visible = false;
                }
                else
                {
                    visibles++;
                }
            }

            if (visibles > 0)
            {
                return true;
            }
            else return false;

        }


        private void tbBusquedaV_TextChanged(object sender, EventArgs e)
        {

            if (tbBusquedaV.Text == "")
            {

                dgvVehiculo.DataSource = misVehiculos.listarAlta();
            }
            else
            {

                string colum = cbFiltroV.SelectedItem.ToString();

                foreach (DataGridViewRow r in dgvVehiculo.Rows)
                {
                    if (busqueda(r.Cells[colum].Value.ToString(), tbBusquedaV.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        r.Visible = true;
                    }
                    else
                    {

                        dgvVehiculo.CurrentCell = null;
                        r.Visible = false;
                    }

                }

            }

        }




        public static bool busqueda(string source, string toCheck, StringComparison comp)
        {
            return source != null && toCheck != null && source.IndexOf(toCheck, comp) >= 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



    }

}

