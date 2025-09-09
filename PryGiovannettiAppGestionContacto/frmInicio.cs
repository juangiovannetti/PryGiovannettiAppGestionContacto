using System.Drawing.Text;

namespace PryGiovannettiAppGestionContacto
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        //Definicion de variables globales
        string vContacto = "";
        string vNumero = "";
        DateTime vFecha = DateTime.Now;
        int vContador = 0;
        int indice = 0;

        //vector
        string[] vecNumero = new string[5];
        string[] vecTelefono = new string[5];

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            vContacto = mtbContacto.Text;
            vNumero = mtbNumero.Text;

            lstResultado.Items.Add("contacto: " + vContacto + "Numero:" + vNumero);

            //grabo en el vector con el indice
            vecNumero[indice] = mtbContacto.Text;
            vecTelefono[indice] = mtbNumero.Text;

            //Limpiar controles
            mtbContacto.Text = "";
            mtbNumero.Text = "";
            mtbContacto.Focus();

            //Mostrar los resultados usando un contador que acumula
            vContador = vContador + 1;
            mtbNumero.Text = ("cantidad de contactos" + vContador);
            mtbContacto.Text = Convert.ToString(vContador);
            lblCantidadContacto.Text = Convert.ToString(vContador);
            indice++;

        }


        private void txtContacto_TextChanged(object sender, EventArgs e)
        {
            if (mtbContacto.Text != "")
            {
                mtbNumero.Enabled = true;
            }
            else
            {
                mtbNumero.Enabled = false;
            }
        }

        private void mtbNumero_TextChanged(object sender, EventArgs e)
        {
            if (mtbNumero.Text != "")
            {
                btnAgendar.Enabled = true;
            }
            else
            {
                btnAgendar.Enabled = false;
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mtbContacto.Text = "";
            mtbNumero.Text = "";
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
              