using System;
using System.Windows.Forms;

namespace ProyectoLogin
{
    public partial class ConexionForm : Form
    {
        public ConexionForm()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Intentando conectar con los datos ingresados...");
        }
    }
}