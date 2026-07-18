using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.MonthCalendar;

namespace Login
{
    public class CatalogoMedicamentos
    {
        public partial class FormCatalogo : Form
        {
            List<Medicamento> lista =
                new List<Medicamento>();

            public FormCatalogo()
            {
                InitializeComponent();

                cmbCategoria.Items.Add("Antibióticos");
                cmbCategoria.Items.Add("Analgésicos");
                cmbCategoria.Items.Add("Vacunas");

                cmbPrioridad.Items.Add("Alta");
                cmbPrioridad.Items.Add("Media");
                cmbPrioridad.Items.Add("Baja");
            }

            private void btnAgregar_Click(object sender, EventArgs e)
            {
                Medicamento med = new Medicamento();

                med.Codigo = txtCodigo.Text;
                med.Nombre = txtNombre.Text;
                med.Categoria = cmbCategoria.Text;
                med.Cantidad = (int)numCantidad.Value;
                med.Prioridad = cmbPrioridad.Text;
                med.Area = txtArea.Text;

                lista.Add(med);

                dgvMedicamentos.DataSource = null;
                dgvMedicamentos.DataSource = lista;

                Limpiar();
            }

            private void Limpiar()
            {
                txtCodigo.Clear();
                txtNombre.Clear();
                txtArea.Clear();
                numCantidad.Value = 0;
            }
        }
    }
}