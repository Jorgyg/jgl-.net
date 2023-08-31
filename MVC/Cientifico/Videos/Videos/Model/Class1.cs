using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Dni { get; set; }
        public DateTime Fecha { get; set; }
    }

    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int ClienteId { get; set; }
    }
}
