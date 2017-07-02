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
    public partial class FrmSeleccionTarifa : Form
    {

        FrmNewAlquiler padre;
        bool confirmado = false;
        string tipo;

        public FrmSeleccionTarifa(FrmNewAlquiler p, string t)
        {
            tipo = t;
            padre = p;
            InitializeComponent();
        }



        public void setVistas(){

            int coincidencia = 0;
            clsTarifa misTarifas = new clsTarifa("Tarifas", "C:\\Sistema de Cochera\\Tarifas");
           

            dgvTarifas.Columns.Clear();

            List<clsTarifa> listado = misTarifas.listarAlta();

            if (listado != null)
            {
                dgvTarifas.DataSource = listado;

                dgvTarifas.Columns[0].Visible = false; //ID
                dgvTarifas.Columns[4].Visible = false;  // ESTADO 
                dgvTarifas.Columns[5].Visible = false;
                dgvTarifas.Columns[6].Visible = false;//HERENCIA:
                dgvTarifas.Columns[7].Visible = false;
                dgvTarifas.Columns[8].Visible = false;
                    

                dgvTarifas.Columns.Add("Tipos", "Tipos");

                var provider = new System.Globalization.CultureInfo("es-AR");
                dgvTarifas.Columns["Precio"].DefaultCellStyle.FormatProvider = provider;
                dgvTarifas.Columns["Precio"].DefaultCellStyle.Format = "C";
                dgvTarifas.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


                foreach (DataGridViewRow fila in dgvTarifas.Rows)
                {
                    foreach (clsTarifa t in listado)
                    {
                        if (t.Id == Convert.ToInt32(fila.Cells["Id"].Value))
                        {
                            fila.Cells["Tipos"].Value = t.obtenerTipos();
                            if (!fila.Cells["Tipos"].Value.ToString().Contains(tipo))
                            {
                                fila.Visible = false;
                            }
                            else {
                                coincidencia++;
                            }
                        }

                    }
                }

                if (coincidencia == 0)
                {
                    MessageBox.Show("No hay Tarifas cargadas aptas para el tipo: " + tipo, "No hay Tarifas");
                    this.Close();
                    }
            }

            else
            {
                MessageBox.Show("No hay Tarifas cargadas aptas para el tipo: " + tipo , "No hay Tarifas");
                this.Close();
            }
        
        }

        private void FrmSeleccionTarifa_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            setVistas();
        }

        private void FrmSeleccionTarifa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (confirmado)
            {
                padre.nombreTarifa = dgvTarifas.SelectedRows[0].Cells["Nombre"].Value.ToString();
                padre.idTar = (int)dgvTarifas.SelectedRows[0].Cells["Id"].Value;
                padre.actualizar();
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            confirmado = true;
            this.Close();
        }
    }
}
