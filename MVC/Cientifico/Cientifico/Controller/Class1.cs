using Cientifico.Model;
using System.Collections.Generic;
using System.Linq;

namespace Cientifico.Controller
{
    public class CientificoController
    {
        private List<Cientific> cientificos;

        public CientificoController()
        {
            cientificos = new List<Cientific>();
        }

        public List<Cientific> ObtenerCientificos()
        {
            return cientificos.ToList();
        }

        public void AgregarCientifico(Cientific cientifico)
        {
            cientificos.Add(cientifico);
        }
    }

    public class ProyectoController
    {
        private List<Proyecto> proyectos;

        public ProyectoController()
        {
            proyectos = new List<Proyecto>();
        }

        public List<Proyecto> ObtenerProyectos()
        {
            return proyectos.ToList();
        }

        public void AgregarProyecto(Proyecto proyecto)
        {
            proyectos.Add(proyecto);
        }
    }

    public class AsignacionController
    {
        private List<AsignadoA> asignaciones;

        public AsignacionController()
        {
            asignaciones = new List<AsignadoA>();
        }

        public List<AsignadoA> ObtenerAsignaciones()
        {
            return asignaciones.ToList();
        }

        public void AgregarAsignacion(AsignadoA asignacion)
        {
            asignaciones.Add(asignacion);
        }

        public void EliminarAsignacion(string dni, string idProyecto)
        {
            asignaciones.RemoveAll(a => a.DNI == dni && a.IdProyecto == idProyecto);
        }
    }
}
