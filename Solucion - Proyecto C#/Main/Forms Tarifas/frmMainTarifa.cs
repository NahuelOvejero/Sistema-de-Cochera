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
using Principal;

namespace Main.Forms_Tarifas
{
    public partial class FrmMainTarifa : Form
    {

        clsTarifa misTarifas;
        FrmNewTarifa oNewT;
        FrmModTarifa oModt;
        public FrmMainTarifa(clsTarifa t)
        {
            misTarifas = t;
            InitializeComponent();
        }

        private void frmMainTarifa_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            setVistas();
           cbFiltroT.SelectedIndex = 0;
           
        }

        public void setVistas()
        {

            dgvTarifas.Columns.Clear();

            List<clsTarifa> listado;
            if (!cbBajas.Checked)
            {
                 listado = misTarifas.listarAlta();
            }
            else{
                listado = misTarifas.listar();
            }

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
                                
                                if(!t.Estado && cbBajas.Checked){
                                    fila.DefaultCellStyle.BackColor = Color.Red;
                                }
                            }
                           
                        }                     
                    }
              }

                else{
                MessageBox.Show("No hay Tarifas cargadas","No hay Tarifas");
                }
            }


        private void btnNewTarifa_Click(object sender, EventArgs e)
        {
            if (oNewT == null || oNewT.IsDisposed)
            {
                oNewT = new FrmNewTarifa(misTarifas, this);
                oNewT.Show();
            }
            else
            {
                oNewT.Focus();
            }
        }

        private void btnModT_Click(object sender, EventArgs e)
        {

            if (dgvTarifas.SelectedRows.Count < 1)
            {
                MessageBox.Show("Seleccione una Tarifa para Modificar", "Error");
            }

            else
            {
                DataGridViewRow fila = dgvTarifas.SelectedRows[0];
                int idTarifa = Convert.ToInt32(fila.Cells["Id"].Value);

                

                if (idTarifa > 0 )
                {

                    if (oModt == null || oModt.IsDisposed)
                    {
                        oModt = new FrmModTarifa(misTarifas, idTarifa, this);
                        oModt.Show();
                    }
                    else
                    {
                        oModt.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("El Inquilino fue eliminado previo al proceso de modificacion", "Eliminado");
                }
            }
        }

        private void cbBajas_CheckedChanged(object sender, EventArgs e)
        {
            setVistas();
            cbFiltroT_SelectedIndexChanged(null, null);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {

            if (dgvTarifas.SelectedRows.Count < 1)
            {
                MessageBox.Show("Selecciones una tarifa para dar de baja", "Error");
            }
            else
            {

                DialogResult result = MessageBox.Show("Quiere dar de baja la tarifa?", "Confirmar Baja", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow fila = dgvTarifas.SelectedRows[0];
                    int id = Convert.ToInt32(fila.Cells["Id"].Value);
                    string bajo = misTarifas.cambiarEstado(id, false);                    
                    MessageBox.Show("Tarifa dada de baja: " + Environment.NewLine + bajo, "Operacion Exitosa");
                    setVistas();
                }
                else
                {
                    MessageBox.Show("Tarifa Conservada", "Operacion Cancelada");
                }

                setVistas();
            }

        }

        private void dgvTarifas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTarifas.SelectedRows.Count > 0)
            {
                bool estado = ((bool)dgvTarifas.SelectedRows[0].Cells["Estado"].Value);
                btnBaja.Enabled = estado;
                btnDarAlta.Enabled = !estado;
            }

        }

        private void btnDarAlta_Click(object sender, EventArgs e)
        {
            if (dgvTarifas.SelectedRows.Count < 1)
            {
                MessageBox.Show("Selecciones un inquilino para eliminar", "Error");
            }
            else
            {

                DialogResult result = MessageBox.Show("Quiere dar de alta la tarifa?", "Confirmar Alta", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow fila = dgvTarifas.SelectedRows[0];
                    int id = Convert.ToInt32(fila.Cells["Id"].Value);
                    string bajo = misTarifas.cambiarEstado(id, true);
                    MessageBox.Show("Tarifa dada de alta: " + Environment.NewLine + bajo, "Operacion Exitosa");

                    setVistas();
                }
                else
                {
                    MessageBox.Show("La Tarifa no fue dada de alta", "Operacion Cancelada");
                }


            }
        }

        private void tbBusquedaT_TextChanged(object sender, EventArgs e)
        {
            if (tbBusquedaT.Text == "" && cbFiltroT.SelectedIndex != 3 && cbFiltroT.SelectedIndex != 4)
            {
                setVistas();
            }
            else
            {

                if (cbFiltroT.SelectedIndex != 3 && cbFiltroT.SelectedIndex != 4)
                {

                    string colum = cbFiltroT.SelectedItem.ToString();
                    foreach (DataGridViewRow r in dgvTarifas.Rows)
                    {
                        if (busqueda(r.Cells[colum].Value.ToString(), tbBusquedaT.Text, StringComparison.OrdinalIgnoreCase))
                        {
                            r.Visible = true;
                        }
                        else
                        {

                            dgvTarifas.CurrentCell = null;
                            r.Visible = false;
                        }

                    }
                }

            }
        }



        public static bool busqueda(string source, string toCheck, StringComparison comp)
        {
            return source != null && toCheck != null && source.IndexOf(toCheck, comp) >= 0;
        }

        private void cbFiltroT_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbBusquedaT_TextChanged(null, null);
        }






    }


}
