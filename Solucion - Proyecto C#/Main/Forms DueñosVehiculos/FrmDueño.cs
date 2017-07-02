using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Main;

namespace Principal
{
    public partial class FrmDueño : Form
    {
        clsDueño misDueños;
        clsVehiculo misVehiculos;

        FrmModInq oModI;
        FrmNewInquilino oNewI;
        FrmNewVehics oNewV;
        FrmModVeh oModV;
        FrmCambioDueño oCDu;

        public FrmDueño(clsDueño d, clsVehiculo v)
        {
            misVehiculos = v;
            misDueños = d;
            InitializeComponent();
        }

        private void FrmDueño_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false; 
            

            recargarVistas();
            dgvInquilinos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVehiculos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (dgvInquilinos.ColumnCount > 0)
            {
                //oculto columna Estado y columna Id
                dgvInquilinos.Columns[0].Visible = false;
                dgvInquilinos.Columns[1].Visible = false;
                dgvInquilinos.Columns[6].Visible = false;
                dgvInquilinos.Columns[7].Visible = false;
                dgvInquilinos.Columns[8].Visible = false;
                dgvInquilinos.Columns[9].Visible = false;

                
                dgvInquilinos.Columns["Dni"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvInquilinos.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      
                
            }

            foreach (DataGridViewRow fila in dgvInquilinos.Rows)
            {
                if (fila.Visible == true)
                {
                    fila.Selected = true;
                }

            }

            if (dgvVehiculos.ColumnCount > 0)
            {
                
                
                dgvVehiculos.Columns[0].Visible = false; //ID
                dgvVehiculos.Columns[1].Visible = false; //ID dueño
                dgvVehiculos.Columns[7].Visible = false;
                dgvVehiculos.Columns[8].Visible = false;
                dgvVehiculos.Columns[9].Visible = false;
                dgvVehiculos.Columns[10].Visible = false;
                dgvVehiculos.Columns[11].Visible = false;

                dgvVehiculos.Columns["Patente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
               
                 
            }

            if (todoOculto() || dgvInquilinos.ColumnCount < 1)
            {
                btnAñadirCoche.Enabled = false;
            }


            dgvInquilinos.ClearSelection();
            dgvVehiculos.ClearSelection();

        }


        public void recargarVistas()
        {

            //setear cb 
            if (cbFiltroV.SelectedItem == null)
            {
                cbFiltroV.SelectedItem = cbFiltroV.Items[0];
            }
            if (cbFiltroI.SelectedItem == null)
            {
                cbFiltroI.SelectedItem = cbFiltroI.Items[0];
            }


            //cargar vist

            dgvInquilinos.DataSource = misDueños.listar();

            dgvVehiculos.DataSource = misVehiculos.listar();


            //ocultar eliminados
            foreach (DataGridViewRow fila in dgvInquilinos.Rows)
            {
                bool aux = (bool)fila.Cells[0].Value;
                if (!aux)
                {
                    this.dgvInquilinos.CurrentCell = null;
                    fila.Visible = false;
                }

            }


            foreach (DataGridViewRow fila in dgvVehiculos.Rows)
            {
                bool aux = (bool)fila.Cells["Estado"].Value;
                if (!aux)
                {
                    this.dgvVehiculos.CurrentCell = null;
                    fila.Visible = false;
                }

            }

            //mostrar bajas

            //mostrar relacion         
   

            if (cbBajas.Checked)
            {
                foreach (DataGridViewRow fila in dgvInquilinos.Rows)
                {
                    bool aux = (bool)fila.Cells["Estado"].Value;
                    if (!aux)
                    {
                        fila.Visible = true;
                        fila.DefaultCellStyle.BackColor = Color.Red;

                    }

                }

            }


            if (cbBajasV.Checked)
            {
                foreach (DataGridViewRow fila in dgvVehiculos.Rows)
                {
                    bool aux = (bool)fila.Cells["Estado"].Value;
                    if (!aux)
                    {
                        fila.Visible = true;
                        fila.DefaultCellStyle.BackColor = Color.Red;

                    }

                }           

                foreach (DataGridViewRow fila in dgvVehiculos.Rows)
                {
                bool aux = (bool)fila.Cells["Estado"].Value;
                if (!aux)
                {
                    this.dgvVehiculos.CurrentCell = null;
                    fila.Visible = false;
                }

                }

            }


            if (dgvInquilinos.Rows.Count > 0) {                
                dgvInquilinos.Rows[0].Selected = true;
                dgvInquilinos_RowEnter(null,null);
            }

            
        }


        //botones


        //btn inquilinos
        private void btnNuevoInquilino_Click(object sender, EventArgs e)
        {
            if (oNewI == null || oNewI.IsDisposed)
            {
                oNewI = new FrmNewInquilino(misDueños, this);
                oNewI.Show();
            }
            else
            {
                oNewI.Focus();
            }
        }

        private void btnEliminarI_Click(object sender, EventArgs e)
        {

            if (dgvInquilinos.SelectedRows.Count < 1)
            {
                MessageBox.Show("Selecciones un inquilino para eliminar", "Error");
            }
            else
            {

                DialogResult result = MessageBox.Show("Quiere dar de baja el Inquilino y todos sus vehiculos?", "Confirmar Eliminacion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow fila = dgvInquilinos.SelectedRows[0];
                    misDueños.eliminarDueño(Convert.ToInt32(fila.Cells[1].Value));
                    string bajo = misVehiculos.bajaDueños(Convert.ToInt32(fila.Cells[1].Value));
                    MessageBox.Show("Inquilino y vehiculos dados de bajas: " + Environment.NewLine + bajo , "Operacion Exitosa");
                }
                else
                {
                    MessageBox.Show("Inquilino Conservado", "Operacion Cancelada");
                }


                recargarVistas();
            }
        }
        
        private void btnModInquilino_Click(object sender, EventArgs e)
        {
            if (dgvInquilinos.SelectedRows.Count < 1)
            {
                MessageBox.Show("Seleccione un inquilino para Modificar", "Error");
            }

            else
            {
                DataGridViewRow fila = dgvInquilinos.SelectedRows[0];
                int dniMod = Convert.ToInt32(fila.Cells["Dni"].Value);

                clsDueño aux = misDueños.existe(dniMod);

                if (aux != null)
                {

                    if (oModI == null || oModI.IsDisposed)
                    {
                        oModI = new FrmModInq(aux, this);
                        oModI.Show();
                    }
                    else
                    {
                        oModI.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("El Inquilino fue eliminado previo al proceso de modificacion", "Eliminado");
                }
            }

            recargarVistas();
        }

        private void btnDarAlta_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Quiere dar de alta el Inquilino y todos sus vehiculos?", "Confirmar Alta", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow fila = dgvInquilinos.SelectedRows[0];
                misDueños.modificar((Convert.ToInt32(fila.Cells[1].Value)), true);
                misVehiculos.altaDueño((Convert.ToInt32(fila.Cells[1].Value)));
                MessageBox.Show("El alta se ha realizado correctamente", "Operacion Exitosa");
            }
            else
            {
                MessageBox.Show("El estado del inquilino no ha cambiado", "Operacion Cancelada");
            }

            recargarVistas();
            
        }

        private void btnAñadirCoche_Click(object sender, EventArgs e)
        {

            if (dgvInquilinos.SelectedRows.Count < 1)
            {
                MessageBox.Show("Selecciones un inquilino para Añadirles Vehiculos", "Error");
            }
            else
            {
                DialogResult result = MessageBox.Show("Quiere asignarle un nuevo Vehiculo?", "Cargar Vehiculo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow fila = dgvInquilinos.SelectedRows[0];
                    int idDueño = Convert.ToInt32(fila.Cells["Id"].Value);
                    if (oNewV == null || oNewV.IsDisposed)
                    {
                        oNewV = new FrmNewVehics(idDueño, this, misVehiculos);
                        oNewV.Show();
                    }
                    else
                    {
                        oNewV.Focus();
                    }


                }
                else
                {
                    MessageBox.Show("El estado del inquilino no ha cambiado", "Operacion Cancelada");
                }
            }
        }

        //btn vehiculos

        private void btnEliminarV_Click(object sender, EventArgs e)
        {


            if (dgvVehiculos.SelectedRows.Count < 1)
            {
                MessageBox.Show("Selecciones un vehiculo para eliminar", "Error");
            }
            else
            {

                DialogResult result = MessageBox.Show("Quiere dar de baja el vehiculo seleccionado?", "Confirmar Baja", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow fila = dgvVehiculos.SelectedRows[0];
                    int idvh = (int)fila.Cells["Id"].Value;
                    if (misVehiculos.eliminarVehiculo(idvh).Equals("eliminado"))
                    {
                        MessageBox.Show("Vehiculo dado de baja", "Operacion Exitosa");
                    }
                    else {
                        MessageBox.Show("No se pudo dar de baja", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Vehiculo Conservado", "Operacion Cancelada");
                }


                recargarVistas();

                dgvInquilinos_RowEnter(null, null);

            }


        }

        private void btnAltaV_Click(object sender, EventArgs e)
        {
            if (dgvVehiculos.SelectedRows.Count < 1)
            {
                MessageBox.Show("Selecciones un Vehiculo para dar de alta", "Error");
            }
            else
            {
                //estado de dueño
                DataGridViewRow filaD = dgvInquilinos.SelectedRows[0];
                bool estadoDueño = (bool)filaD.Cells["Estado"].Value;

                if (estadoDueño)
                {
                    DialogResult result = MessageBox.Show("Quiere dar de Alta el vehiculo seleccionado?", "Confirmar Alta", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        DataGridViewRow fila = dgvVehiculos.SelectedRows[0];
                        int idvh = (int)fila.Cells["Id"].Value;
                        misVehiculos.modificar(idvh, true);
                        MessageBox.Show("Vehiculo dado De Alta", "Operacion Exitosa");
                    }
                    else
                    {
                        MessageBox.Show("El vehiculo no se ha dado de alta", "Operacion Cancelada");
                    }


                    recargarVistas();

                    dgvInquilinos_RowEnter(null, null);

                }
                else {

                    MessageBox.Show("No se puede dar el alta a un vehiculo de un dueño de baja","Dueño del Vehiculo de baja");
                
                }


            }
        }

        private void btnModificarV_Click(object sender, EventArgs e)
        {

            if (dgvVehiculos.SelectedRows.Count < 1)
            {
                MessageBox.Show("Seleccione un Vehiculo para Modificar", "Error");
            }

            else
            {
                DataGridViewRow fila = dgvVehiculos.SelectedRows[0];
                string pat = fila.Cells["Patente"].Value.ToString();

                clsVehiculo vehaux = misVehiculos.existe(pat);

                if (vehaux != null)
                {

                    if (oModV == null || oModV.IsDisposed)
                    {
                        oModV = new FrmModVeh(vehaux, this);
                        oModV.Show();
                    }
                    else
                    {
                        oModV.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("El Inquilino fue eliminado previo al proceso de modificacion", "Eliminado");
                }
            }

            recargarVistas();
        }

        private void btnCambiarDueño_Click(object sender, EventArgs e)
        {
            if (dgvVehiculos.SelectedRows.Count < 1)
            {
                MessageBox.Show("Selecciones un vehiculo para cambiar de Dueño", "Error");
            }
            else
            {
                clsVehiculo aux = misVehiculos.existe(dgvVehiculos.SelectedRows[0].Cells["Patente"].Value.ToString());
                if (aux != null)
                {

                    if (oCDu == null || oCDu.IsDisposed)
                    {
                        oCDu = new FrmCambioDueño(aux, this);
                        oCDu.Show();
                    }
                    else
                    {
                        oCDu.Focus();
                    }
                
                }
                else
                {
                    MessageBox.Show("El Vehiculo fue eliminado durante el proceso de modificacion", "Error");
                }
            }
        }
        
        //busquedas

        private void tbBusquedaI_TextChanged(object sender, EventArgs e)
        {

            if (tbBusquedaI.Text == "")
            {
                recargarVistas();
            }
            else
            {
                string colum = cbFiltroI.SelectedItem.ToString();

                foreach (DataGridViewRow r in dgvInquilinos.Rows) {
                    if(busqueda(r.Cells[colum].Value.ToString(), tbBusquedaI.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        r.Visible = true;
                    }
                    else
                    {

                        dgvInquilinos.CurrentCell = null;
                        r.Visible = false;
                    }
                    
                }
            }
             

        }

        private void cbFiltroI_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbBusquedaI_TextChanged(tbBusquedaI, e);
        }

        private void cbBajasV_CheckedChanged(object sender, EventArgs e)
        {
            btnAltaV.Visible = cbBajasV.Checked;

            if (cbBajasV.Checked)
            {

                foreach (DataGridViewRow fila in dgvVehiculos.Rows)
                {
                    bool aux = (bool)fila.Cells["Estado"].Value;
                    if (!aux)
                    {
                        fila.Visible = true;
                        fila.DefaultCellStyle.BackColor = Color.Red;

                    }

                }
            }

                foreach (DataGridViewRow fila in dgvVehiculos.Rows)
                {
                    bool aux = (bool)fila.Cells["Estado"].Value;
                    if (!aux)
                    {
                        this.dgvVehiculos.CurrentCell = null;
                        fila.Visible = false;
                    }

                }

                dgvInquilinos_RowEnter(null, null);

            
        }
                
        private void tbBusquedaV_TextChanged(object sender, EventArgs e)
        {

            if (tbBusquedaV.Text == "")
            {
                foreach (DataGridViewRow r in dgvVehiculos.Rows) {

                    r.Visible = true;
                }
            }
            else
            {

                string colum = cbFiltroV.SelectedItem.ToString();

                foreach (DataGridViewRow r in dgvVehiculos.Rows)
                {
                    if (busqueda(r.Cells[colum].Value.ToString(), tbBusquedaV.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        r.Visible = true;
                    }
                    else
                    {

                        dgvVehiculos.CurrentCell = null;
                        r.Visible = false;
                    }

                }
            }
        }

        private void cbBajas_CheckedChanged(object sender, EventArgs e)
        {
            btnDarAlta.Visible = cbBajas.Checked;

            recargarVistas();

            dgvInquilinos_RowEnter(null, null);


        }

        // Funciones auxiliares

        public bool todoOculto()
        {

            int i = 0;

            foreach (DataGridViewRow fila in dgvInquilinos.Rows)
            {
                bool aux = (bool)fila.Cells[0].Value;
                if (aux)
                {
                    i++;
                }

            }

            if (i > 0)
            {
                return false;
            }
            else return true;

        }

        //tech
        
        public static bool busqueda(string source, string toCheck, StringComparison comp)
        {
            return source != null && toCheck != null && source.IndexOf(toCheck, comp) >= 0;
        }
        
        
        //actualizacion de la relacion
        private void dgvInquilinos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInquilinos.SelectedRows.Count > 0)
            {
                btnDarAlta.Enabled = !((bool)dgvInquilinos.SelectedRows[0].Cells[0].Value);
                btnAñadirCoche.Enabled = ((bool)dgvInquilinos.SelectedRows[0].Cells[0].Value);
                btnEliminarI.Enabled = ((bool)dgvInquilinos.SelectedRows[0].Cells[0].Value);
            }

            if (dgvInquilinos.SelectedRows.Count > 0)
            {
                int idDueño = (int)dgvInquilinos.SelectedRows[0].Cells["Id"].Value;
                foreach (DataGridViewRow fila in dgvVehiculos.Rows)
                {
                    bool estado = (bool)fila.Cells["Estado"].Value;
                    int veh = (int)fila.Cells[1].Value;
                    if (veh == idDueño)
                    {
                        if (cbBajasV.Checked && !estado)
                        {
                            fila.Visible = true;
                            fila.DefaultCellStyle.BackColor = Color.Red;
                        }
                        if (estado)
                        {
                            fila.Visible = true;
                        }
                    }
                    else
                    {
                        dgvVehiculos.CurrentCell = null;
                        fila.Visible = false;
                    }
                }

            }
        }

        private void dgvVehiculos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvVehiculos.SelectedRows.Count > 0)
            {
                bool estado = ((bool)dgvVehiculos.SelectedRows[0].Cells["Estado"].Value);
                btnEliminarV.Enabled = estado;
                btnAltaV.Enabled = !estado;
            }

            if (dgvVehiculos.SelectedRows.Count > 0)
            {
                int idDueño = (int)dgvVehiculos.SelectedRows[0].Cells["IdDueño"].Value;
                foreach (DataGridViewRow fila in dgvInquilinos.Rows)
                {
                    bool estado = (bool)fila.Cells["Estado"].Value;
                    int veh = (int)fila.Cells[1].Value;
                    if (veh == idDueño)
                    {
                        fila.Selected = true;
                    }
                }

            }

        }

        private void dgvVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvInquilinos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlBusquedaV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbFiltroV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



   
      
    
    


    }
}
