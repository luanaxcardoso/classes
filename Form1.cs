using System.Reflection.Metadata;

namespace exercioaula7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContaEspecialcs conta1 = new ContaEspecialcs();

            conta1.abertura(4000);

            label1.Text = " R$ " + conta1.Saldo.ToString() + " e R$" + conta1.Limite.ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Contapoupanca conta2= new Contapoupanca();

            conta2.abertura(3000);

            label2.Text = " R$ " + conta2.Saldo.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}