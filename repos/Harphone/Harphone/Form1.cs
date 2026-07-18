using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harphone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Abriendo el perfil del usuario para ver/modificar información.", "Mi Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
           


        }

        private void button3_Click(object sender, EventArgs e)
        {



        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abriendo el formulario para reportar fallos en la aplicación.", "Reportar Fallos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abriendo el formulario para dejar sugerencias y mejoras.", "Sugerencias", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool isAdmin = true; 

            if (isAdmin)
            {
                MessageBox.Show("Accediendo a las Herramientas de Administrador.", "Acceso de Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Acceso denegado. No tienes permisos de administrador.", "Acceso Restringido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
    }
}
