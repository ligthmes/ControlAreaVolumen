namespace ControlAreaVolumen
{
    public partial class frmControlAreaVolumen : Form
    {
        public frmControlAreaVolumen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Calcualr los valores 
            double altura = double.Parse (txtAltura.Text);
            double diametro = double.Parse (txtDiametro.Text);

            //Realizando los  calculos 
            double radio = diametro / 2;
            double area = (2 * Math.PI * radio) * radio + altura;
            double volumen = Math.PI * Math.Pow(radio, 2) * altura;

            //Mostrando los resultado en el cuadro de texto
            txtR.Text = "*** Resumen de volumen y areas ***";
            txtR.Text += "\r\n VALOR ALTURA" + altura.ToString("00.0");
            txtR.Text += "\r\n VALOR DIAMETRO" + diametro.ToString("00.0");
            txtR.Text += "\r\n -------------------------------------------";
            txtR.Text += "\r\n VALOR RADIO" + radio.ToString("00.0");
            txtR.Text += "\r\n VALOR AREA" + area.ToString("00.0");
            txtR.Text += "\r\n VALOR VOLUMEN" + volumen.ToString("00.0");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           txtAltura.Clear();
           txtDiametro.Clear();
           txtR.Clear();
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir?", "Control de pago", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}