using System;
using System.Collections.Generic;

namespace Ex1.Models;

public partial class Pieza
{
    public int Codigo { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Suministra> Suministras { get; set; } = new List<Suministra>();
}
