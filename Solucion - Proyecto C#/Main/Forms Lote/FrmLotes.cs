using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MisClass;

namespace Main.Forms_Lote
{
    public partial class FrmLotes : Form
    {

        clsLote misLotes;

        public FrmLotes(clsLote l)
        {
            misLotes = l;
            InitializeComponent();
        }

        private void FrmLotes_Load(object sender, EventArgs e)
        {
            cbBusqueda.SelectedIndex = 0;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            setVistas();
            rbMod.Checked = true;
            rbCarga.Checked = true;
            dgvLotes.ClearSelection();
        }

        public void setVistas() { 
        
            
            List<clsLote> listado = misLotes.listar();

            if (listado != null && listado.Count > 0) {

                dgvLotes.DataSource = listado;
                dgvLotes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                foreach (DataGridViewRow fila in dgvLotes.Rows) {

                    string est = fila.Cells["Estado"].Value.ToString();
                    if(est.Equals("Baja")){

                        fila.DefaultCellStyle.BackColor = Color.Red;
                        }
                    if (est.Equals("Libre"))
                    {

                        fila.DefaultCellStyle.BackColor = Color.Green;
                    }
                    if (est.Equals("Ocupado"))
                    {

                        fila.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    if (est.Equals("Mantenimiento"))
                    {

                        fila.DefaultCellStyle.BackColor = Color.Orange;
                    }

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

        private void rbMod_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCarga.Checked)
            {
                btnCambiar.Text = "Cargar";
                tbNombre.Clear();
                cbEstado.SelectedIndex = 0;
            }
            else {
                btnCambiar.Text = "Cambiar";
                dgvLotes_RowEnter(null, null);
            }
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {

            if(tbNombre.Text.Length >2){
            if (rbCarga.Checked)
            {
                if (!misLotes.existe(tbNombre.Text))
                {
                    DialogResult result = MessageBox.Show("Quiere cargar un nuevo lote?", "Confirmar Carga", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        misLotes.NuevoLote(tbNombre.Text, cbEstado.SelectedItem.ToString(),cbTipo.SelectedItem.ToString());
                        MessageBox.Show("Nuevo Lote Guardado", "Operacion Exitosa");
                        setVistas();
                        tbNombre.Clear();
                        cbEstado.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("El lote no se ha conservado", "Operacion Cancelada");
                    }
                }
                else {
                    MessageBox.Show("Ya hay un Lote con ese Nombre", "Nombre Duplicado");
                }
            }

            else {

                string estado = dgvLotes.SelectedRows[0].Cells["Estado"].Value.ToString();

                if(!estado.Equals("Ocupado")){

                if (tbNombre.Text.Length > 1)
                {

                    DialogResult result = MessageBox.Show("Realmente quiere modificar este Lote?", "Confirmar Modificacion", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        int idX = Convert.ToInt32(dgvLotes.SelectedRows[0].Cells["Id"].Value);
                        misLotes.modificar(idX, tbNombre.Text,cbEstado.SelectedItem.ToString(),cbTipo.SelectedItem.ToString());                        
                        MessageBox.Show("Modificaciones del Lote Guardadas", "Operacion Exitosa");
                        rbCarga.Checked = true;
                        setVistas();
                        tbNombre.Clear();
                        cbEstado.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("El lote no se ha modificado", "Operacion Cancelada");
                    }
                }
                else 
                {
                    MessageBox.Show("Ingrese un Nombre mas largo", "Error");
                }
            
                }

                else{
                
                    MessageBox.Show("No puede modificar un lote alquilado." + Environment.NewLine + "Para liberar el Lote, debera realizarlo desde la seccion de Alquileres" ,"Lote Ocupado");
                }

            
            }
            }
            else{
                MessageBox.Show("Nombre del lote demasiado corto, ingrese un nombre mas largo","Ingrese un Nombre mas largo");
            }
            
        }

        private void dgvLotes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (rbMod.Checked && dgvLotes.Rows.Count > 0) {
                try
                {
                    tbNombre.Text = dgvLotes.SelectedRows[0].Cells["Nombre"].Value.ToString();
                    cbEstado.SelectedItem = dgvLotes.SelectedRows[0].Cells["Estado"].Value.ToString();
                    cbTipo.SelectedItem = dgvLotes.SelectedRows[0].Cells["Tipo"].Value.ToString();
                }
                catch (ArgumentOutOfRangeException our) {
                    MessageBox.Show(our.Message + ". Debe seleccionar un Lote para continuar", "Fuera de Rango");
                }
            }
        }

        private void tbBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (cbBusqueda.SelectedIndex == 0)
            {

                string colum = cbBusqueda.SelectedItem.ToString();
                foreach (DataGridViewRow r in dgvLotes.Rows)
                {
                    if (busqueda(r.Cells["Nombre"].Value.ToString(), tbBusqueda.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        r.Visible = true;
                    }
                    else
                    {

                        dgvLotes.CurrentCell = null;
                        r.Visible = false;
                    }
                }
            }

            else { 

                string tipo = cbBusqueda.SelectedItem.ToString();

                foreach (DataGridViewRow r in dgvLotes.Rows)
                {
                    if (busqueda(r.Cells["Estado"].Value.ToString(), tipo, StringComparison.OrdinalIgnoreCase) && busqueda(r.Cells["Nombre"].Value.ToString(), tbBusqueda.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        r.Visible = true;
                    }
                    else
                    {

                        dgvLotes.CurrentCell = null;
                        r.Visible = false;
                    }
                
                 }
            
            }

        }

        private void cbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbBusqueda.SelectedIndex == 0)
            {
                tbBusqueda_TextChanged(null, null);
            }
            else
            {

                string tipo = cbBusqueda.SelectedItem.ToString();

                foreach (DataGridViewRow r in dgvLotes.Rows)
                {
                    if (busqueda(r.Cells["Estado"].Value.ToString(), tipo, StringComparison.OrdinalIgnoreCase))
                    {
                        r.Visible = true;
                    }
                    else
                    {

                        dgvLotes.CurrentCell = null;
                        r.Visible = false;
                    }
                }
            }

        }



        public static bool busqueda(string source, string toCheck, StringComparison comp)
        {
            return source != null && toCheck != null && source.IndexOf(toCheck, comp) >= 0;
        }




    }
}
