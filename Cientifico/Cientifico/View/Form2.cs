using Cientifico.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cientifico.View
{
    public partial class FormCrearProyecto : Form
    {
        public Proyecto ProyectoCreado { get; private set; }

        public FormCrearProyecto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string nombre = txtNombre.Text;
            int horas;

            if (!string.IsNullOrWhiteSpace(id) && !string.IsNullOrWhiteSpace(nombre) &&
                int.TryParse(txtHoras.Text, out horas))
            {
                ProyectoCreado = new Proyecto(id, nombre, horas);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Por favor, completa todos los campos y asegúrate de que las horas sean un número válido.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
