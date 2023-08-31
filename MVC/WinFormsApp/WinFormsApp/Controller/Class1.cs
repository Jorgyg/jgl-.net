using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Model;

namespace WinFormsApp.Controller
{
    public class ClienteController
    {
        private List<Cliente> clientes = new List<Cliente>();

        public void AgregarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public void EditarCliente(Cliente cliente)
        {
            Cliente clienteExistente = clientes.Find(c => c.Id == cliente.Id);
            if (clienteExistente != null)
            {
                clienteExistente.Nombre = cliente.Nombre;
                clienteExistente.Apellido = cliente.Apellido;
                clienteExistente.Direccion = cliente.Direccion;
                clienteExistente.Dni = cliente.Dni;
                clienteExistente.Fecha = cliente.Fecha;
            }
        }

        public void EliminarCliente(int clienteId)
        {
            Cliente clienteExistente = clientes.Find(c => c.Id == clienteId);
            if (clienteExistente != null)
            {
                clientes.Remove(clienteExistente);
            }
        }

        public List<Cliente> ObtenerClientes()
        {
            return clientes.ToList();
        }
    }

}
