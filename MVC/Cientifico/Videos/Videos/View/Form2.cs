using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Controller;
using WinFormsApp.Model;

namespace Videos.View
{
    public partial class Form2 : Form
    {
        private VideoController videoController;
        private int clienteId;

        public Form2(int idCliente)
        {
            InitializeComponent();
            clienteId = idCliente;
            videoController = new VideoController();
            CargarDatos(clienteId);
        }
        public void CargarDatos(int idCliente)
        {
            dataGridView1.DataSource = videoController.ObtenerVideosPorCliente(idCliente);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string director = txtDirector.Text;

            Video video = new Video();
            video.Title = nombre;
            video.Director = director;

            videoController.AgregarVideo(video);
            CargarDatos(clienteId);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int videoId = ObtenerIdVideoSeleccionado();

            if (videoId != -1)
            {
                videoController.EliminarVideo(videoId);
                CargarDatos(clienteId);
            }
        }

        private int ObtenerIdVideoSeleccionado()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                return Convert.ToInt32(selectedRow.Cells["Id"].Value);
            }
            return -1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
