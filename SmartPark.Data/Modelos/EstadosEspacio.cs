using System;
using System.Collections.Generic;

namespace SmartPark.Data.Modelos;

public partial class EstadosEspacio
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Espacio> Espacios { get; set; } = new List<Espacio>();
}
