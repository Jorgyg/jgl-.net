using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Videos.View;
using WinFormsApp.Controller;
using WinFormsApp.Model;
using Videos.View;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private ClienteController clienteController = new ClienteController();
        private Cliente clienteSeleccionado;
        public Form1()
        {
            InitializeComponent();
            CargarClientesEnDataGridView();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                clienteSeleccionado = (Cliente)dataGridView1.SelectedRows[0].DataBoundItem;
            }
            else
            {
                clienteSeleccionado = null;
            }
        }


        private void CargarClientesEnDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clienteController.ObtenerClientes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente
            {
                Nombre = txtNombre.Text,
                Apellido = txtDesc.Text,
                Direccion = txtMarca.Text,
                Dni = int.Parse(txtPrecio.Text),
                Fecha = DateTime.Parse(txtStock.Text)
            };

            clienteController.AgregarCliente(nuevoCliente);
            CargarClientesEnDataGridView();
            LimpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado != null)
            {
                // Mostrar los datos del cliente seleccionado en los campos de edición
                txtNombre.Text = clienteSeleccionado.Nombre;
                txtDesc.Text = clienteSeleccionado.Apellido;
                txtMarca.Text = clienteSeleccionado.Direccion;
                txtPrecio.Text = clienteSeleccionado.Dni.ToString();
                txtStock.Text = clienteSeleccionado.Fecha.ToString();

                // Realizar la edición del cliente
                Cliente clienteEditado = new Cliente
                {
                    Id = clienteSeleccionado.Id,
                    Nombre = txtNombre.Text,
                    Apellido = txtDesc.Text,
                    Direccion = txtMarca.Text,
                    Dni = int.Parse(txtPrecio.Text),
                    Fecha = DateTime.Parse(txtStock.Text)
                };

                clienteController.EditarCliente(clienteEditado);
                CargarClientesEnDataGridView();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para editar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado != null)
            {
                int clienteId = clienteSeleccionado.Id;
                clienteController.EliminarCliente(clienteId);

                CargarClientesEnDataGridView();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para eliminar.");
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtDesc.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtStock.Text = string.Empty;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado != null)
            {
                int clienteId = clienteSeleccionado.Id;
                Form2 detallesForm = new Form2(clienteId);
                detallesForm.Show();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para ver sus videos.");
            }
        }
    }
}
