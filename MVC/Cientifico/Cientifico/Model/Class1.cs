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

        public Cientific(string dni, string nomApels)
        {
            DNI = dni;
            NomApels = nomApels;
        }
    }

    public class Proyecto
    {
        private static int contadorId = 1;

        public int Id { get; }
        public string Nombre { get; set; }
        public int Horas { get; set; }

        public Proyecto(string nombre, int horas)
        {
            Id = contadorId++;
            Nombre = nombre;
            Horas = horas;
        }
    }

    public class AsignadoA
    {
        public string DNI { get; set; }
        public string IdProyecto { get; set; }

        public AsignadoA(string dni, string idProyecto)
        {
            DNI = dni;
            IdProyecto = idProyecto;
        }
    }



}
