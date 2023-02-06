namespace Calculator
    {
    public partial class Form1 : Form
        {
        Calculadora funcao = new Calculadora(); 
        private void Add(int numero) 
            {
            if ((labelVisor).Text.Length < 13)
                {
                labelVisor.Text += numero;
                }
            }

        
        private void Concatenar(string elemento)
            {
            labelVisor.Text += elemento;
            }

        private void Substituir (double valor)
            {
            labelVisor.Text = valor.ToString();
            }

        public void Resolver()
            {
            if (labelVisor.Text.Contains("+")) {
                string[] Calculo = labelVisor.Text.Split('+');
                Substituir (double.Parse(Calculo[0]) + double.Parse(Calculo[1]));
                }
            else if (labelVisor.Text.Contains("-"))
                {
                string[] Calculo = labelVisor.Text.Split('-');
                Substituir (double.Parse(Calculo[0]) - double.Parse(Calculo[1]));
                }
            else if (labelVisor.Text.Contains("x"))
                {
                string[] Calaculo = labelVisor.Text.Split("x");
                Substituir (double.Parse(Calaculo[0]) * double.Parse(Calaculo[1]));
                }
            else if (labelVisor.Text.Contains("÷")) 
                {
                string[] Calculo = labelVisor.Text.Split("÷");
                Substituir (double.Parse(Calculo[0]) / double.Parse(Calculo[1]));
                }
            }

        public Form1()
            {
            InitializeComponent();
            }
        Calculadora Funcoes = new Calculadora();
        private void button1_Click(object sender, EventArgs e)
            {
            Add(1);
            }

        private void button2_Click(object sender, EventArgs e)
            {
            Add(2);
            }

        private void button3_Click(object sender, EventArgs e)
            {
            Add(3);
            }

        private void button4_Click(object sender, EventArgs e)
            {
            Add(4);
            }

        private void button5_Click(object sender, EventArgs e)
            {
            Add(5);
            }

        private void button6_Click(object sender, EventArgs e)
            {
            Add(6);
            }

        private void button7_Click(object sender, EventArgs e)
            {
            Add(7);
            }

        private void button8_Click(object sender, EventArgs e)
            {
            Add(8);
            }

        private void button9_Click(object sender, EventArgs e)
            {
            Add(9);
            }

        private void button0_Click(object sender, EventArgs e)
            {
            Add(0);
            }

        private void buttonClear_Click(object sender, EventArgs e)
            {
            labelVisor.Text = "";
            }

        private void buttonVirgula_Click(object sender, EventArgs e)
            {
            Concatenar(",");
            }

        private void buttonMais_Click(object sender, EventArgs e)
            {
            Resolver();
            Concatenar("+");
            }

        private void buttonMenos_Click(object sender, EventArgs e)
            {
            Resolver();
            Concatenar("-");
            }

        private void buttonMultiplicacao_Click(object sender, EventArgs e)
            {
            Resolver();
            Concatenar("x");
            }

        private void buttonDividir_Click(object sender, EventArgs e)
            {
            Resolver();
            Concatenar("÷");
            }

        private void buttonResultado_Click(object sender, EventArgs e)
            {
            Resolver();
            }

        private void buttonPorcentagem_Click(object sender, EventArgs e)
            {

            }

        private void buttonInverter_Click(object sender, EventArgs e)
            {
            string vazio = "";
            string separar = labelVisor.Text;

            }

        private void buttonBackSpace_Click(object sender, EventArgs e)
            {
            labelVisor.Text += "\b";
            }
        }
    }