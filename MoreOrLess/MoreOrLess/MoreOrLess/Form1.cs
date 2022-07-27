namespace MoreOrLess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            List<string> textos = new List<string> { textBox4.Text, textBox5.Text, textBox6.Text };
            List<int> numeros = new List<int>();
            int numeroMayor = 0;
            int numeroMenor = 0;


            foreach (string texto in textos)
            {
                int numero = Convert.ToInt32(texto);
                numeros.Add(numero);
            }

            for (int i = 0; i < numeros.Count; i++)
            {
                numeroMayor = numeros[0];
                numeroMenor = numeros[0];

                if (numeros[i] > numeroMayor)
                {
                    numeroMayor = numeros[i];
                }
                if (numeros[i] < numeroMenor)
                {
                    numeroMenor = numeros[i];
                }
            }
            MessageBox.Show($"El lower number is {numeroMenor} and the highest number is {numeroMayor}");
        }
        /*
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        */

    }
}