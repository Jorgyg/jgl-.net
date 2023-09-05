namespace Ex1.Models
{
    public class Fabricante
    {
        public int Codigo { get; set; }
        public String Nombre { get; set; }
        public ICollection<Articulo> Articulos { get; set; } = new List<Articulo>();

    }

    public class Articulo
    {
        public int Codigo { get; set; }
        public String Nombre { get; set; }
        public int Precio { get; set; }
        public int FabricanteCodigo { get; set; }
        public Fabricante Fabricante { get; set; }
    }
}
