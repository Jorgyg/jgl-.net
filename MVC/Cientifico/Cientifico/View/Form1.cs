using Cientifico.Controller;
using Cientifico.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cientifico
{
    public partial class Form1 : Form
    {
        private CientificoController cientificoController;
        private ProyectoController proyectoController;
        private AsignacionController asignacionController;

        public Form1()
        {
            InitializeComponent();

            // Inicializar los controladores
            cientificoController = new CientificoController();
            proyectoController = new ProyectoController();
            asignacionController = new AsignacionController();

            CargarDatos();
        }

        private void CargarDatos()
        {
            // Cargar datos de científicos, proyectos y asignaciones en los DataGridView
            List<Cientific> cientificos = cientificoController.ObtenerCientificos();
            List<Proyecto> proyectos = proyectoController.ObtenerProyectos();
            List<AsignadoA> asignaciones = asignacionController.ObtenerAsignaciones();

            dgvCientificos.DataSource = cientificos;
            dgvProyectos.DataSource = proyectos;
            dgvAsignaciones.DataSource = asignaciones;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {

            string dni = dgvCientificos.SelectedRows[0].Cells["DNI"].Value.ToString();
            string idProyecto = dgvProyectos.SelectedRows[0].Cells["Id"].Value.ToString();

            asignacionController.AgregarAsignacion(new AsignadoA(dni, idProyecto));
            CargarDatos();
        }

        private void btnEliminarAsignacion_Click(object sender, EventArgs e)
        {
            string dni = dgvCientificos.SelectedRows[0].Cells["DNI"].Value.ToString();
            string idProyecto = dgvProyectos.SelectedRows[0].Cells["Id"].Value.ToString();

            // Eliminar la asignación
            asignacionController.EliminarAsignacion(dni, idProyecto);
            CargarDatos();
        }

        private void btnCrearCientifico_Click(object sender, EventArgs e)
        {
            string dni = txtNuevoCientifico.Text;
            string nombre = textBox1.Text;

            // Crear un nuevo científico
            Cientific cientifico = new Cientific(dni, nombre);
            cientificoController.AgregarCientifico(cientifico);
            CargarDatos();
        }

        private void btnCrearProyecto_Click(object sender, EventArgs e)
        {
            string nombreProyecto = textBox2.Text;
            int horasProyecto;

            if (int.TryParse(textBox3.Text, out horasProyecto))
            {
                Proyecto proyecto = new Proyecto(nombreProyecto, horasProyecto);
                proyectoController.AgregarProyecto(proyecto);
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor válido para las horas del proyecto.");
            }
        }
    }
}
