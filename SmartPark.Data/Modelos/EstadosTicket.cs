using System;
using System.Collections.Generic;

namespace SmartPark.Data.Modelos;

public partial class EstadosTicket
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
