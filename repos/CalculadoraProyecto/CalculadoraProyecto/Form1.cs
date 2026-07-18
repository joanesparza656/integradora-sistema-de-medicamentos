using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraProyecto
{
    public partial class FrmCalculadora : Form
    {
        double resultado;
        OperationCanceledException operaciones = new OperationCanceledException();

        public TextBox textnumero1;
        public TextBox textnumero2;

        public FrmCalculadora()
        {
            InitializeComponent();
            // Inicializa los controles si no están en el diseñador
            textnumero1 = new TextBox();
            textnumero2 = new TextBox();
            // Si usas el diseñador, asegúrate de que los nombres coincidan
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Suponiendo que 'operacions1' tiene un método 'Sumar' que recibe dos doubles
            resultado = peraciones.Sumar(Convert.ToDouble(textnumero1.Text), Convert.ToDouble(textnumero2.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
