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
    public partial class FrmNewTarifa : Form
    {
        clsTarifa misTarifas;
        FrmMainTarifa padre;




        /*
         * 
         * 
         * ACOMDODAR COLUMNASSSSSSSSSSSSSSS POR HORA
         * 
         * 
         * */



        public FrmNewTarifa(clsTarifa T, FrmMainTarifa p)
        {
            misTarifas = T;
            padre = p;
            InitializeComponent();
        }

        private void FrmNewTarifa_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false; 
            
        }

        private void btnCargarTarifa_Click(object sender, EventArgs e)
        {
            if (validar()) {
                 string res = "";
                 try
                 {
                     res = misTarifas.GrabarTarifa(tbNombre.Text, tbDescripcion.Text, nudPrecio.Value, archivarTipos(), true);
                     MessageBox.Show("La tarifa se ha guardado con exito", "Tarifa Guardada");
                 }

                 catch (Exception ex)
                 {
                     MessageBox.Show(res + ex.ToString(), "Error");
                 }

                 finally {
                     this.Close();
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
        
        private void FrmNewTarifa_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.setVistas();
        }


        public bool[] archivarTipos() {

            bool[] arr = new bool[4];

            arr[0] = cbAuto.Checked;
            arr[1] = cbMoto.Checked;
            arr[2] = cbCamioneta.Checked;
            arr[3] = cbCamion.Checked;

            return arr;
            
        }


        }

    }

