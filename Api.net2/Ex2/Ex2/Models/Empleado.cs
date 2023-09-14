namespace Ex2.Models
{

    public class Departamento
    {
        public int Codigo { get; set; }
        public String Nombre { get; set; }
        public int Presupuesto { get; set; }
        public ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
    }

    public class Empleado
    {
        public String Dni { get; set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public int DepartamentoCodigo { get; set; }
        public Departamento Departamentos { get; set; }
    }
}
