namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double Sumar(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Restar(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Dividir(double num1, double num2)
        {
            return num1 / num2;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double resultado = Sumar(num1, num2);
            label3.Text = "Resultado: " + resultado;
        }

        // Botón Restar (button2)
        private void button2_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double resultado = Restar(num1, num2);
            label3.Text = "Resultado: " + resultado;
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double resultado = Multiplicar(num1, num2);
            label3.Text = "Resultado: " + resultado;
        }

        // Botón Dividir (button4)
        private void button4_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);

            // Validación para no dividir entre cero
            if (num2 == 0)
            {
                MessageBox.Show("No se puede dividir entre cero");
                return;
            }

            double resultado = Dividir(num1, num2);
            label3.Text = "Resultado: " + resultado;
        }

       
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
    }
}
    
