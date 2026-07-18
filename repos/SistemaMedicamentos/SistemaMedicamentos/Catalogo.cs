using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace SistemaMedicamentos
{
    public partial class Catalogo : Form
    {
        List<Medicamento> medicamentos = new List<Medicamento>();

        public Catalogo()
        {
            InitializeComponent();
            cmbCategoria.Items.Add("Antibióticos");
            cmbCategoria.Items.Add("Analgésicos");
            cmbCategoria.Items.Add("Vacunas");

            cmbPrioridad.Items.Add("Alta");
            cmbPrioridad.Items.Add("Media");
            cmbPrioridad.Items.Add("Baja");
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {

        }
    }


}
