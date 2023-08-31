using Cientifico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cientifico.Controller
{
    public class CientificoController
    {
        private List<Cientific> cientificos;

        public CientificoController()
        {
            cientificos = new List<Cientific>();
        }

        public void AgregarCientifico(Cientific cientifico)
        {
            cientificos.Add(cientifico);
        }

        public List<Cientific> ObtenerCientificos()
        {
            return cientificos;
        }

        public void ActualizarCientifico(string dni, string nuevoNombre)
        {
            Cientific cientifico = cientificos.Find(c => c.DNI == dni);
            if (cientifico != null)
            {
                cientifico.NomApels = nuevoNombre;
            }
        }

        public void EliminarCientifico(string dni)
        {
            cientificos.RemoveAll(c => c.DNI == dni);
        }
    }

    public class ProyectoController
    {
        private List<Proyecto> proyectos;

        public ProyectoController()
        {
            proyectos = new List<Proyecto>();
        }

        public void AgregarProyecto(Proyecto proyecto)
        {
            proyectos.Add(proyecto);
        }

        public List<Proyecto> ObtenerProyectos()
        {
            return proyectos;
        }

        public void ActualizarProyecto(string id, string nuevoNombre)
        {
            Proyecto proyecto = proyectos.Find(p => p.Id == id);
            if (proyecto != null)
            {
                proyecto.Nombre = nuevoNombre;
            }
        }

        public void EliminarProyecto(string id)
        {
            proyectos.RemoveAll(p => p.Id == id);
        }
    }

    public class AsignadoAController
    {
        private List<AsignadoA> asignaciones;

        public AsignadoAController()
        {
            asignaciones = new List<AsignadoA>();
        }

        public void AgregarAsignacion(AsignadoA asignacion)
        {
            asignaciones.Add(asignacion);
        }

        public List<AsignadoA> ObtenerAsignaciones()
        {
            return asignaciones;
        }

        public void EliminarAsignacion(string dniCientifico, string idProyecto)
        {
            asignaciones.RemoveAll(a => a.DNI == dniCientifico && a.IdProyecto == idProyecto);
        }
    }
}
