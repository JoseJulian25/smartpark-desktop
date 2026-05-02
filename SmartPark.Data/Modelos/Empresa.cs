using System;
using System.Collections.Generic;

namespace SmartPark.Data;

public partial class Empresa
{
    public long Id { get; set; }

    public string Direccion { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Rnc { get; set; } = null!;

    public string Telefono { get; set; } = null!;
}
