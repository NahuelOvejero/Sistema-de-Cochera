using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Principal;
using System.Text.RegularExpressions;

namespace Main
{
    public partial class FrmModVeh : Form
    {

        clsVehiculo misV = new clsVehiculo("Vehiculos", "C:\\Sistema de Cochera\\Vehiculos");
        FrmDueño act;
        clsVehiculo modi;

        public FrmModVeh(clsVehiculo V ,FrmDueño formu)
        {
            act = formu;
            modi = V;
            InitializeComponent();
        }

        private void FrmModVeh_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            tbPatente.Text = modi.Patente;
            tbModelo.Text = modi.Modelo;
            tbColor.Text = modi.Color;
            tbObs.Text = modi.Observaciones;
            cbTipo.SelectedItem = modi.Tipo.ToString();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            
            if (misV.existe(tbPatente.Text) != null && misV.existe(tbPatente.Text).Id != modi.Id)
            {

                clsVehiculo recuperado = misV.existe(tbPatente.Text);
                MessageBox.Show("Ya hay un Vehiculo con Patente: " + tbPatente.Text + Environment.NewLine + "Tipo : " + recuperado.Tipo + " Modelo: " + recuperado.Modelo, "Patente Duplicada");
                
            }

            else
            {
                if (verificar())
                {
                    misV.modificar(modi.Id, modi.IdDueño, tbPatente.Text, tbModelo.Text, tbColor.Text, cbTipo.SelectedItem.ToString(), tbObs.Text);
                    MessageBox.Show("Se han guardado los cambios", " Modificacion Correcta");
                    this.Close();
                }
            }
        }

        public bool verificar()
        {

            bool exito = true;
            bool camionNeta = false;
            Regex regex = new Regex("[aA-zZ]{3}[0-9]{3}");
            string mensaje = "La patente de un Auto debe iniciar con 3 letras y 3 numeros." + Environment.NewLine + "Ej : AAA111";

            if (cbTipo.SelectedItem.ToString().Equals("Moto"))
            {
                regex = new Regex("[0-9]{3}[aA-zZ]{3}");
                mensaje = "La patente de Moto debe iniciar con 3 numeros y terminar con 3 letras." + Environment.NewLine + "Ej : 111AAA";
            }

            if (cbTipo.SelectedItem.ToString().Equals("Camion") || cbTipo.SelectedItem.ToString().Equals("Camioneta"))
            {

                regex = new Regex("[0-9]{3}[aA-zZ]{3}");
                Regex standar = new Regex("[aA-zZ]{2}[0-9]{3}[aA-zZ]{2}");
                Match matcheo = regex.Match(tbPatente.Text);
                Match match2 = standar.Match(tbPatente.Text);
                camionNeta = true;

                if (matcheo.Success || match2.Success)
                {
                    if (matcheo.Success)
                        tbPatente.Text = matcheo.Value;
                    else
                        tbPatente.Text = match2.Value;

                    tbPatente.BackColor = Color.White;
                }
                else
                {
                    MessageBox.Show("La patente puede tener los siguientes formatos: 111AAA ó AB123CD", "Patente Incorrecta");
                    tbPatente.BackColor = Color.Red;
                    exito = false;
                }

            }

            Match match = regex.Match(tbPatente.Text);
            if (!camionNeta)
            {

                if (match.Success)
                {
                    tbPatente.Text = match.Value;
                    tbPatente.BackColor = Color.White;
                }
                else
                {
                    MessageBox.Show(mensaje, "Patente Incorrecta");
                    tbPatente.BackColor = Color.Red;
                    exito = false;
                }

            }

            regex = new Regex("[aA-zZ]{4,}");

            match = regex.Match(tbColor.Text);

            if (tbColor.Text.Equals(string.Empty) || !(match.Success))
            {
                MessageBox.Show("El campo de color debe tener 4 letras o mas", "Ingrese color");
                tbColor.BackColor = Color.Red;
                exito = false;
            }
            else
            {
                tbColor.BackColor = Color.White;
            }



            if (tbModelo.Text.Equals(string.Empty))
            {
                MessageBox.Show("El modelo es un campo obligatorio", "Ingrese Modelo");
                tbModelo.BackColor = Color.Red;
                exito = false;
            }
            else
            {
                tbModelo.BackColor = Color.White;
            }



            return exito;
        }

        private void FrmModVeh_FormClosed(object sender, FormClosedEventArgs e)
        {
            act.recargarVistas();
        }

    }
}
