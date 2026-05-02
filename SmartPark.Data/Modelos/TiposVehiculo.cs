using System;
using System.Collections.Generic;

namespace SmartPark.Data.Modelos;

public partial class TiposVehiculo
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Espacio> Espacios { get; set; } = new List<Espacio>();

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();

    public virtual Tarifa? Tarifa { get; set; }

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
