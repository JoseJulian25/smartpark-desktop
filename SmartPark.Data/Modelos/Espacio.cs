using System;
using System.Collections.Generic;

namespace SmartPark.Data.Modelos;

public partial class Espacio
{
    public long Id { get; set; }

    public bool Activo { get; set; }

    public string CodigoEspacio { get; set; } = null!;

    public DateTime? FechaCreacion { get; set; }

    public int EstadoId { get; set; }

    public int TipoVehiculoId { get; set; }

    public virtual EstadosEspacio Estado { get; set; } = null!;

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    public virtual TiposVehiculo TipoVehiculo { get; set; } = null!;
}
