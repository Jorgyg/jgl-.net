using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
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

    public class VideoController
    {
        private List<Video> videos = new List<Video>();
        private Cliente cliente;

        public void AgregarVideo(Video video)
        {
            videos.Add(video);
        }

        public void EditarVideo(Video video)
        {
            Video videoExistente = videos.Find(v => v.Id == video.Id);
            if (videoExistente != null)
            {
                videoExistente.Title = video.Title;
                videoExistente.Director = video.Director;
            }
        }

        public void EliminarVideo(int videoId)
        {
            Video videoExistente = videos.Find(v => v.Id == videoId);
            if (videoExistente != null)
            {
                videos.Remove(videoExistente);
            }
        }

        public List<Video> ObtenerVideosPorCliente(int clienteId)
        {
            List<Video> videosCliente = new List<Video>();

            foreach (Video video in videos)
            {
                if (video.ClienteId == clienteId)
                {
                    videosCliente.Add(video);
                }
            }

            return videosCliente;
        }

    }
}

