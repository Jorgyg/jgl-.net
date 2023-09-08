using System;
using System.Collections.Generic;

namespace Ex1.Models;

public partial class Suministra
{
    public int CodigoPieza { get; set; }

    public string ProveedorId { get; set; } = null!;

    public double? Precio { get; set; }

    public virtual Pieza CodigoPiezaNavigation { get; set; } = null!;
}
