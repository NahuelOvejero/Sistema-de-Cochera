using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MisClass;

namespace Main.Forms_Tarifas
{
    public partial class FrmModTarifa: Form
    {
        clsTarifa misTarifas;
        FrmMainTarifa padre;
        int idmod;
        

        public FrmModTarifa(clsTarifa T, int id, FrmMainTarifa p)
        {
            misTarifas = T;
            padre = p;
            idmod = id;           
            InitializeComponent();
        }

        private void FrmModTarifa_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            clsTarifa t = misTarifas.existe(idmod);
            if (t != null)
            {
                tbNombre.Text = t.Nombre;
                cbAuto.Checked = t.Tipo[0];
                cbMoto.Checked = t.Tipo[1];
                cbCamioneta.Checked = t.Tipo[2];
                cbCamion.Checked = t.Tipo[3];
                nudPrecio.Value = t.Precio;
                tbDescripcion.Text = t.Descripcion;
            }

            else {

                MessageBox.Show("Se elimino la tarifa mientras se editaba, intente de nuevo","Error");
                this.Close();
            }
            
        }

        private void btnCargarTarifa_Click(object sender, EventArgs e)
        {
            if (validar()) {
                 string res = "";
                try
                {
                    res = misTarifas.modificar(idmod, tbNombre.Text, tbDescripcion.Text, archivarTipos(), nudPrecio.Value);
                    MessageBox.Show("La tarifa se ha modificado con exito", "Tarifa Modificada");
                    this.Close();
                }

                catch (Exception ex) {
                    MessageBox.Show(res + ex.ToString(), "Error");
                }
            }
        }



        public bool validar() {

          bool exito = true;

           
            if ( tbNombre.Text.Length > 3)
            {
                tbNombre.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("El nombre debe poseer al menos 4 letras","Nombre muy corto");
                tbNombre.BackColor = Color.Red;
                exito = false;
            }


            if (!cbAuto.Checked && !cbMoto.Checked && !cbCamion.Checked && !cbCamioneta.Checked){
                MessageBox.Show("Seleccione al menos un tipo en el cual se aplicable la tarifa", "Seleccione Tipo");
                exito = false;
            }



            if (nudPrecio.Value < 1)
            {
                MessageBox.Show("Ingrese un precio valido", "Ingrese Modelo");
                exito = false;    
            }


            return exito;
        }



        public bool[] archivarTipos() {

            bool[] arr = new bool[4];

            arr[0] = cbAuto.Checked;
            arr[1] = cbMoto.Checked;
            arr[2] = cbCamioneta.Checked;
            arr[3] = cbCamion.Checked;

            return arr;
            
        }

        private void FrmModTarifa_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.setVistas();
        }


        }

    }

