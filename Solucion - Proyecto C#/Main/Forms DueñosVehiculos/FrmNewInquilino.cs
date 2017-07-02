using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Principal
{
    public partial class FrmNewInquilino : Form
    {

        clsDueño misDueños;
        FrmDueño act;

        public FrmNewInquilino(clsDueño d, FrmDueño pasaje)
        {
            act = pasaje;
            misDueños = d;
            InitializeComponent();
        }

        private void btnCargarInquilino_Click(object sender, EventArgs e)
        {
            string res = getErrores();

            if (res == string.Empty)
            {

                try
                {

                    if (misDueños.existe(Convert.ToInt32(tbDni.Text)) == null)
                    {
                        misDueños.GrabarDueño(Convert.ToInt32(tbDni.Text), tbNombre.Text, tbApellido.Text, tbTelefono.Text, true);
                        MessageBox.Show("La carga se realizo exitosamente", "Exito");

                        foreach (Control c in this.Controls)
                        {
                            if (c is TextBox)
                            {
                                (c as TextBox).Clear();

                            }
                        }

                    }
                    else
                    {

                        clsDueño Aux = misDueños.existe(Convert.ToInt32(tbDni.Text));

                        MessageBox.Show("Ya existe un Inquilino con DNI:" + tbDni.Text.ToString() + "." + Environment.NewLine + "Nombre: " + Aux.Nombre + " " + Aux.Apellido, "Inquilino Existente");

                        tbDni.Focus();
                    }

                    tbDni.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString() + Environment.NewLine + "Verifique Los datos nuevamente", "Datos Invalidos");
                }
            }

            else {

                MessageBox.Show(res, "Error de datos");
            }
        }




      private string tbDni_Leave(object sender, EventArgs e)
        {
            string res = string.Empty;
           
            Regex regex = new Regex(@"\d{8}");
            Match match = regex.Match(tbDni.Text);
            if (match.Success)
            {
                tbDni.Text = match.Value;
                tbDni.BackColor = Color.White;
            }
            else
            {
                res = "El Dni debe tener 8 numeros";
                tbDni.BackColor = Color.Red;                
            }
            return res;
        }

      private string tbNombre_Leave(object sender, EventArgs e)
        {

            string res = string.Empty;
            string remplazo = tbNombre.Text;
            for (int i = 0; i < 10; i++)
            {
                string a = i.ToString();
                remplazo = remplazo.Replace(a, "");
            }

            tbNombre.Text = remplazo;

            if (tbNombre.Text == "")
            {


                res = "El Nombre no puede estar Vacio";
                tbNombre.BackColor = Color.Red;
            }

            else
            {
                tbNombre.BackColor = Color.White;
            }
            return res;

        }

      private string tbApellido_Leave(object sender, EventArgs e)
        {

            string res = string.Empty;

            string remplazo = tbApellido.Text;
            for (int i = 0; i < 10; i++)
            {
                string a = i.ToString();
                remplazo = remplazo.Replace(a, "");
            }

            tbApellido.Text = remplazo;

            if (tbApellido.Text == "")
            {

                res = "El Apellido no puede estar Vacio";
                tbApellido.BackColor = Color.Red;
            }

            else
            {
                tbApellido.BackColor = Color.White;
            }

            return res;
        }

      private string tbTelefono_Leave(object sender, EventArgs e)
            {

                string res = string.Empty;

                 Regex regex = new Regex(@"\d{6,12}");
                 Match match = regex.Match(tbTelefono.Text);
                  if (match.Success)
            {
                tbTelefono.Text = match.Value;
                tbTelefono.BackColor = Color.White;
            }
            else
            {

                res = "El telefono debe tener de 6 a 12 caracteres númericos";
                tbTelefono.BackColor = Color.Red;
            }

                  return res;

        }

      private void FrmNewInquilino_FormClosed(object sender, FormClosedEventArgs e)
             {

                 act.recargarVistas();
             }

      private void FrmNewInquilino_Load(object sender, EventArgs e)
      {
          this.FormBorderStyle = FormBorderStyle.FixedSingle;
          this.MaximizeBox = false; 
            
      }

        public string getErrores(){

            string resultado = string.Empty;
        
            if( tbApellido_Leave(this, EventArgs.Empty) != string.Empty)
                resultado += tbApellido_Leave(this, EventArgs.Empty) + "\n";
            if (tbDni_Leave(this, EventArgs.Empty) != string.Empty)
                resultado += tbDni_Leave(this, EventArgs.Empty) + "\n";
            if (tbNombre_Leave(this, EventArgs.Empty) != string.Empty)
                resultado += tbNombre_Leave(this, EventArgs.Empty) + "\n";
            if (tbTelefono_Leave(this, EventArgs.Empty) != string.Empty)
                resultado += tbTelefono_Leave(this, EventArgs.Empty);

            return resultado;

    }
    }

}
