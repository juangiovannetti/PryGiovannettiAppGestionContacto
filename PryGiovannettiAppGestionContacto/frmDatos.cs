using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryGiovannettiAppGestionContacto
{
    public partial class frmVerContacto : Form
    {
        public frmVerContacto()
        {
            InitializeComponent();
        }
        // Declaracion de variables 
        public string[] vecContacto = new string[5];
        int indice = 0;

        //variable auxiliar para concatenar y mostrar al array
        string resultado = "";

        private void frmVerContacto_Load(object sender, EventArgs e)
        {
            

            lblDatos.Text = vecContacto[0];


        }


        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //muestra el valor siguiente a la posicion actual del array
            indice++; // indice = indice + 1
            lblDatos.Text = vecContacto[indice];

            //validamos no pasar el liite de dimencion del array
            if (vecContacto.Length <= (indice + 1))
            {
                btnSiguiente.Enabled = false;
            }
            //validamos que en la siguiente posicion haya algo que mostrar
            if (vecContacto[indice + 1] is not null)
            {
                btnSiguiente.Enabled = true;
            }
            else 
            {
                btnSiguiente.Enabled = false;
            }

            //habilitamos el btnAtras que se encuntra deshabilitado
            btnAtras.Enabled = false;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //muestra el valor anterior en la posicion actual del array
            indice--;
            lblDatos.Text = vecContacto[indice];

            //validacion si estamos en posicion 0, se deshabilita el btnAtras
             if (vecContacto.Length <= (indice - 1))
            {
                btnAtras.Enabled = false;
            }

             //Validacion para no pasar de la dimension del array
             if (indice < 5)
            {
                btnAtras.Enabled = true;
            }
        }
    }
}
