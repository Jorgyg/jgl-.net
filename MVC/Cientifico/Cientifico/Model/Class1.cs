using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cientifico.Model
{
    public class Cientific
    {
        public string DNI { get; set; }
        public string NomApels { get; set; }
    }

    public class Proyecto
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public int Horas { get; set; }
    }

    public class AsignadoA
    {
        public string DNI { get; set; }
        public string IdProyecto { get; set; }
    }



}
