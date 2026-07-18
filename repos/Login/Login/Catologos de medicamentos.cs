using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class Catologos_de_medicamentos : Form
    {
       

           
           // Añadir campos en la clase (nivel de clase)
private ComboBox cmbCategoria;
private ComboBox cmbPrioridad;

        // En el constructor del formulario, antes de usar Items.AddRange(...)
        public Catologos_de_medicamentos()
        {
    InitializeComponent();

    // Crear e inicializar si no existen (útil si no usas el diseñador)
    cmbCategoria ??= new ComboBox
    {
        Name = "cmbCategoria",
        Location = new System.Drawing.Point(20, 20),
        Size = new System.Drawing.Size(160, 28)
    };
    cmbPrioridad ??= new ComboBox
    {
        Name = "cmbPrioridad",
        Location = new System.Drawing.Point(20, 60),
        Size = new System.Drawing.Size(160, 28)
    };

    // Añadir a Controls si no están en el diseñador
    if (!Controls.Contains(cmbCategoria)) Controls.Add(cmbCategoria);
    if (!Controls.Contains(cmbPrioridad)) Controls.Add(cmbPrioridad);

    // Ahora puedes usar las llamadas que indicaste
    cmbCategoria.Items.Clear();
    cmbCategoria.Items.AddRange(new object[] { "Antibióticos", "Analgésicos", "Vacunas" });

    cmbPrioridad.Items.Clear();
    cmbPrioridad.Items.AddRange(new object[] { "Alta", "Media", "Baja" });
}
            

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

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

            };private void Limpiar()
{
    // Limpiar textos si los controles existen
    txtCodigo?.Clear();
    txtNombre?.Clear();
    txtArea?.Clear();

    // Restaurar valor mínimo seguro para NumericUpDown
    if (numCantidad != null)
    {
        var min = numCantidad.Minimum;
        var max = numCantidad.Maximum;
        if (min <= max) numCantidad.Value = min;
    }

    // Deseleccionar combo boxes de forma segura
    if (cmbCategoria != null) cmbCategoria.SelectedIndex = -1;
    if (cmbPrioridad != null) cmbPrioridad.SelectedIndex = -1;

    // Devolver foco si existe el control
    txtCodigo?.Focus();
}
            private void Limpiar() {

            txtCodigo.Clear();
            txtNombre.Clear();
            txtArea.Clear();
        }
    }
}
        
   
    

