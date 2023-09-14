namespace Ex4.Models
{
    public class Pelicula
    {
        public int Codigo { get; set; }

        public String Nombre { get; set; }

        public int Edad { get; set; }
        public ICollection<Sala> Sala { get; set; } = new List<Sala>();

    }

    public class Sala
    {
        public int Codigo { get; set; }

        public String Nombre { get; set; }

        public int PeliculaCodigo { get; set; }
        public Pelicula Pelicula { get; set; }
    }
}
