using Practica_3.Modelo;
using Practica_3.ModeloDaO;

namespace Practica_3
{
    public partial class Form1 : Form
    {
        BoletoDao dao = new BoletoDao();

        public Form1()
        {
            InitializeComponent();
        }
        public void CargarDatos()
        {
            dgvBoletos.DataSource = dao;

        }


        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Boleto boleto = new Boleto();
            boleto.Cliente = TxtPelicula.Text;
            boleto.pelicula = TxtPelicula.Text;
            boleto.sala = Convert.ToInt32(txtSala.Text);
            boleto.cantidadBoletos = Convert.ToInt32(txtCantidad.texto.Text);
            boleto.Total = boleto.cantidadBoletos * 80;
            boleto.Fecha = DateTime.Now;
            dao.Guardar(boleto);
            MessageBox.Show("EL BOLETO SE AH REGISTRADO");


        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvBoletos?.CurrentRow?.Cells [0].Value);
            dao.Eliminar(id);
            CargarDatos();
            MessageBox.Show("EL REGISTRO SE AH ELIMINADO CORRECTAMENTE");
        }
    }
}
