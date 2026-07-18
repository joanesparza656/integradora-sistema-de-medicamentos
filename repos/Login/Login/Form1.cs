

    
namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtPassword.Text == "1234")
            {
                var frm = new Catologos_de_medicamentos();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos 😕");
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Login
{
    public partial class FormCatalogo : Form
    {
        private readonly List<Medicamento> lista = new();

        public FormCatalogo()
        {
            InitializeComponent();

            // Inicializar categorías y prioridades (asegura que los controles existan en el diseñador)
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.AddRange(new object[] { "Antibióticos", "Analgésicos", "Vacunas" });

            cmbPrioridad.Items.Clear();
            cmbPrioridad.Items.AddRange(new object[] { "Alta", "Media", "Baja" });
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var med = new Medicamento
            {
                Codigo = txtCodigo.Text?.Trim(),
                Nombre = txtNombre.Text?.Trim(),
                Categoria = cmbCategoria.Text,
                Cantidad = (int)numCantidad.Value,
                Prioridad = cmbPrioridad.Text,
                Area = txtArea.Text?.Trim()
            };

            lista.Add(med);

            // Refrescar origen de datos
            dgvMedicamentos.DataSource = null;
            dgvMedicamentos.DataSource = lista.ToArray(); // ToArray() fuerza la actualización; considera BindingList<T> para edición dinámica

            Limpiar();
        }

        private void Limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtArea.Clear();
            numCantidad.Value = numCantidad.Minimum;
            cmbCategoria.SelectedIndex = -1;
            cmbPrioridad.SelectedIndex = -1;
            txtCodigo.Focus();
        }
    }
}

        }
    }
}