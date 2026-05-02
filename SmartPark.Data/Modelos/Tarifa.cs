using System;
using System.Collections.Generic;

namespace SmartPark.Data.Modelos;

public partial class Tarifa
{
    public long Id { get; set; }

    public DateTime? ActualizadoEn { get; set; }

    public int MinutosFraccion { get; set; }

    public int MinutosMinimo { get; set; }

    public int MinutosTolerancia { get; set; }

    public decimal PrecioPorFraccion { get; set; }

    public int TipoVehiculoId { get; set; }

    public virtual TiposVehiculo TipoVehiculo { get; set; } = null!;
}
