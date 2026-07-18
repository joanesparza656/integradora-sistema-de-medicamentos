using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text.Trim().ToUpper() == "ADMIN")
            {
                if (textBox2.Text == "12345")
                {
                  MdiPrincipal mdiPrincipal = new MdiPrincipal();
                    mdiPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            else
            {
               MessageBox.Show("Usuario incorrecto", "Login",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
