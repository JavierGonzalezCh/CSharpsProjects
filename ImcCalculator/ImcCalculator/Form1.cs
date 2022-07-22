namespace ImcCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string textoPeso = txtPeso.Text;
            double peso = Double.Parse(textoPeso);
            string textoAltura = txtAltura.Text;
            double altura = Double.Parse(textoAltura);

            double imc = peso / (altura * altura);

            MessageBox.Show("El IMC es" + imc);

        }
    }
}