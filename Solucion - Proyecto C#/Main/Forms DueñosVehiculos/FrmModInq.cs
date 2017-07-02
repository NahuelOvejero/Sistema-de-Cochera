using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Main;
using System.Text.RegularExpressions;
using Principal;

namespace Main
{
    public partial class FrmModInq : Form
    {

        clsDueño aux= new clsDueño("Inquilinos","C:\\Sistema de Cochera\\Inquilinos");
        FrmDueño act;

        public FrmModInq(clsDueño modi, FrmDueño formu)
        {
            act = formu;

            aux.Id = modi.Id;
            aux.Dni = modi.Dni;
            aux.Apellido = modi.Apellido;
            aux.Nombre = modi.Nombre;
            aux.Telefono = modi.Telefono;

            InitializeComponent();

        }

        private void FrmModInq_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            tbDni.Text = aux.Dni.ToString();
            tbNombre.Text = aux.Nombre;
            tbApellido.Text = aux.Apellido;
            tbTelefono.Text = aux.Telefono.ToString();

        }

        private void btnCargarInquilino_Click(object sender, EventArgs e)
        {

            string resultado = "";
            int dniPrueba = 0;
            try
            {
                dniPrueba = (Convert.ToInt32(tbDni.Text));
            }
            catch(FormatException ex) {
                MessageBox.Show("Introduzca 8 valores numericos en el dni.", "Error");
                return;
            }

            if (aux.existe(dniPrueba) != null && aux.existe(dniPrueba).Id != aux.Id )
            {
                clsDueño recuperado = aux.existe(Convert.ToInt32(tbDni.Text));
                MessageBox.Show("Ya hay un inquilino con dni: " + tbDni.Text + Environment.NewLine + "Nombre : " + recuperado.Nombre + " " + recuperado.Apellido, "Dni duplicado");
                
            }
            else
            {

                try
                {
                    if (testeo().Equals(string.Empty))
                    {
                        if (tbTelefono.BackColor != Color.Red)
                        {
                            int idCambio = aux.Id;
                            resultado = aux.modificar(idCambio, Convert.ToInt32(tbDni.Text), tbNombre.Text, tbApellido.Text, tbTelefono.Text);

                            if (resultado.Equals("cambio realizado"))
                            {
                                MessageBox.Show("Cambios Realizados", "Operacion Exitosa");
                                this.Close();
                            }
                        }
                        else {

                            MessageBox.Show("Verifique que el telefono contenga de 6 a 12 caracteres numericos", "Han ocurrido los siguientes errores");
                        }
                    }
                    else {

                        MessageBox.Show(testeo(), "Han ocurrido los siguientes errores");
                    
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString() + Environment.NewLine + "Verifique Los datos nuevamente" + Environment.NewLine + resultado, "Datos Invalidos");
                }


            }

        }





        private void FrmModInq_FormClosed(object sender, FormClosedEventArgs e)
        {

            act.recargarVistas();
        }


        private string testeo() {
            string prueba = string.Empty;

            if (tbDni.Text.Length < 8) {
                prueba += "El documento debe tener 8 caracteres numericos" + Environment.NewLine ;
            }
            if (tbNombre.Text.Length < 2) {
                prueba += "El nombre no puede tener menos de 2 caracteres" + Environment.NewLine;
            }
            if (tbApellido.Text.Length < 2)
            {
                prueba += "El apellido no puede tener menos de 2 caracteres" + Environment.NewLine;
            }
            if (tbTelefono.Text.Length < 6)
            {
                prueba += "El telefono no puede tener menos de 6 caracteres" + Environment.NewLine;
            }

            return prueba;
        
        }








        private void tbDni_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"\d{8}");
            Match match = regex.Match(tbDni.Text);
            if (match.Success)
            {
                tbDni.Text = match.Value;
                tbDni.BackColor = Color.White;
            }
            else
            {                
                tbDni.BackColor = Color.Red;
            }
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            string remplazo = tbNombre.Text;
            for (int i = 0; i < 10; i++)
            {
                string a = i.ToString();
                remplazo = remplazo.Replace(a, "");
            }

            tbNombre.Text = remplazo;

            if (tbNombre.Text == "")
            {
                tbNombre.BackColor = Color.Red;
            }

            else
            {
                tbNombre.BackColor = Color.White;
            }
        }

        private void tbTelefono_TextChanged(object sender, EventArgs e)
        {

            Regex regex = new Regex(@"\d{6,12}");
            Match match = regex.Match(tbTelefono.Text);
            if (match.Success)
            {
                tbTelefono.Text = match.Value;
                tbTelefono.BackColor = Color.White;
            }
            else
            {
                tbTelefono.BackColor = Color.Red;
            }

        }

        private void tbApellido_TextChanged(object sender, EventArgs e)
        {
            string remplazo = tbApellido.Text;
            for (int i = 0; i < 10; i++)
            {
                string a = i.ToString();
                remplazo = remplazo.Replace(a, "");
            }

            tbApellido.Text = remplazo;

            if (tbApellido.Text == "")
            {

                tbApellido.BackColor = Color.Red;
            }

            else
            {
                tbApellido.BackColor = Color.White;
            }
        }

    }
}




