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
    public partial class MdiPrincipal : Form
    {
        public MdiPrincipal()
        {
            InitializeComponent();
        }

       

        private void menusalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MdiPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCatClientes catClientes = new FrmCatClientes();
            catClientes.MdiParent = this;
            catClientes.Show();
        }
    }
}
