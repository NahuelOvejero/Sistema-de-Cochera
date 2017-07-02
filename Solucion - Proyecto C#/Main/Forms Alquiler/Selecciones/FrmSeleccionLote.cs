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
    public partial class FrmSeleccionLote : Form
    {
        FrmNewAlquiler padre;
        bool confirmado = false;
        string tipo;
        clsLote misLotes = new clsLote("Lotes", "C:\\Sistema de Cochera\\Lotes");

        public FrmSeleccionLote( FrmNewAlquiler p, string tip)
        {
            tipo = tip;
            padre = p;
            InitializeComponent();
        }


        private void FrmSeleccionLote_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            btnOK.Enabled = setVistas();
        }
        

        public bool setVistas()
        {
            int visibles = 0;
            dgvLotes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            List<clsLote> listado = misLotes.listar();

            if (listado != null && listado.Count > 0)
            {

                dgvLotes.DataSource = listado;
                dgvLotes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                foreach (DataGridViewRow fila in dgvLotes.Rows)
                {

                    string est = fila.Cells["Estado"].Value.ToString();

                    if (est.Equals("Libre") && tipo.Equals(fila.Cells["Tipo"].Value.ToString()))
                    {

                        fila.DefaultCellStyle.BackColor = Color.Green;
                        visibles++;
                    }
                    else
                    {
                        dgvLotes.CurrentCell = null;
                        fila.Visible = false;
                    }

                }

                if (dgvLotes.Columns.Count > 0)
                {


                    dgvLotes.Columns[0].Visible = false;
                    dgvLotes.Columns[4].Visible = false;
                    dgvLotes.Columns[5].Visible = false;
                    dgvLotes.Columns[6].Visible = false;
                    dgvLotes.Columns[7].Visible = false;

                }

            }

            else
            {
                MessageBox.Show("No hay lotes disponibles");
                this.Close();
            }

            if (visibles > 0) { return true; }
            else return false;
        }

        private void FrmSeleccionLote_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (confirmado && dgvLotes.SelectedRows.Count > 0)
            {
                padre.idLote = (int)dgvLotes.SelectedRows[0].Cells["Id"].Value;
                padre.nombreLote = dgvLotes.SelectedRows[0].Cells["Nombre"].Value.ToString();
                padre.actualizar();
            }
            else if(confirmado) {
                MessageBox.Show("Seleccione un Lote para continuar", "Lote Sin Seleccionar");
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            confirmado = true;
            this.Close();
        }

        private void dgvLotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



    }
}
