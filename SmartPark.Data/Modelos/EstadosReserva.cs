using System;
using System.Collections.Generic;

namespace SmartPark.Data.Modelos;

public partial class EstadosReserva
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
}
