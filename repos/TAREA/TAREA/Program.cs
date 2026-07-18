using System;
using System.Windows.Forms;
;

namespace CalculadoraApp
{
    public partial class Form1 : Forms
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ObtenerNumeros(out double numero1, out double numero2)
        {
            bool valido1 = double.TryParse(txtNumero1.Text, out numero1);
            bool valido2 = double.TryParse(txtNumero2.Text, out numero2);

            if (!valido1 || !valido2)
            {
                MessageBox.Show("Por favor, ingrese números válidos.");
                txtResultado.Clear();
                return false;
            }
            return true;
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (ObtenerNumeros(out double n1, out double n2))
            {
                var calc = new Calculadora(n1, n2);
                txtResultado.Text = calc.Sumar().ToString();
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (ObtenerNumeros(out double n1, out double n2))
            {
                var calc = new Calculadora(n1, n2);
                txtResultado.Text = calc.Restar().ToString();
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (ObtenerNumeros(out double n1, out double n2))
            {
                var calc = new Calculadora(n1, n2);
                txtResultado.Text = calc.Multiplicar().ToString();
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (ObtenerNumeros(out double n1, out double n2))
            {
                var calc = new Calculadora(n1, n2);
                try
                {
                    txtResultado.Text = calc.Dividir().ToString();
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message);
                    txtResultado.Clear();
                }
            }
        }
    }
}
