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
        string[] vecNombre = new string[5];
        int indice = 0;
        private void frmVerContacto_Load(object sender, EventArgs e)
        {
            vecNombre[0] = "Juan";
            vecNombre[1] = "Pedro";
            vecNombre[3] = "carlos";
            vecNombre[4] = "tiziana";

            lblDatos.Text = vecNombre[0];


        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            indice++; // indice = indice + 1
            lblDatos.Text = vecNombre[indice];

            if (vecNombre.Length <= (indice + 1))
            {
                btnSiguiente.Enabled = false;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //muestra el valor anterior en la posicion actual del array
            indice--;
            lblDatos.Text = vecNombre[indice];

            //validacion si estamos en posicion 0, se deshabilita el btnAtras


            if (vecNombre.Length <= (indice - 1))
            {
                btnAtras.Enabled = false;
            }
        }
    }
}
