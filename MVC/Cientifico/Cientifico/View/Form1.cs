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
        private AsignadoAController asignadoAController;

        public Form1()
        {
            InitializeComponent();

            // Inicializar los controladores
            cientificoController = new CientificoController();
            proyectoController = new ProyectoController();
            asignadoAController = new AsignadoAController();

            CargarDatos();
        }

        private void CargarDatos()
        {
            List<Cientific> cientificos = cientificoController.ObtenerCientificos();
            List<Proyecto> proyectos = proyectoController.ObtenerProyectos();

            // Cargar los datos en los DataGridView
            dgvCientificos.DataSource = cientificos;
            dgvProyectos.DataSource = proyectos;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (dgvCientificos.SelectedRows.Count > 0 && dgvProyectos.SelectedRows.Count > 0)
            {
                string dni = dgvCientificos.SelectedRows[0].Cells["DNI"].Value.ToString();
                string idProyecto = dgvProyectos.SelectedRows[0].Cells["Id"].Value.ToString();

                asignadoAController.AgregarAsignacion(new AsignadoA(dni, idProyecto));
                CargarDatos();
            }
        }

        private void btnCrearCientifico_Click(object sender, EventArgs e)
        {

            using (FormCrearCientifico formCrearCientifico = new FormCrearCientifico())
            {
                DialogResult result = formCrearCientifico.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Cientific nuevoCientifico = formCrearCientifico.CientificoCreado;
                    cientificoController.AgregarCientifico(nuevoCientifico);
                    CargarDatos();
                }
            }
        }

        private void btnCrearProyecto_Click(object sender, EventArgs e)
        {
            using (FormCrearProyecto formCrearProyecto = new FormCrearProyecto())
            {
                DialogResult result = formCrearProyecto.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Proyecto nuevoProyecto = formCrearProyecto.ProyectoCreado;
                    proyectoController.AgregarProyecto(nuevoProyecto);
                    CargarDatos();
                }
            }
        }

        private void btnEliminarAsignacion_Click(object sender, EventArgs e)
        {
            if (dgvAsignaciones.SelectedRows.Count > 0)
            {
                string dni = dgvAsignaciones.SelectedRows[0].Cells["DNI"].Value.ToString();
                string idProyecto = dgvAsignaciones.SelectedRows[0].Cells["IdProyecto"].Value.ToString();

                asignadoAController.EliminarAsignacion(dni, idProyecto);
                CargarDatos();
            }
        }
    }
}
