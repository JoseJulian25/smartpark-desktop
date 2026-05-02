using System;
using System.Collections.Generic;

namespace SmartPark.Data.Modelos;

public partial class Pago
{
    public long Id { get; set; }

    public DateTime HoraPago { get; set; }

    public string MetodoPago { get; set; } = null!;

    public decimal Monto { get; set; }

    public decimal MontoRecibido { get; set; }

    public long? ProcesadoPor { get; set; }

    public long TicketId { get; set; }

    public virtual Usuario? ProcesadoPorNavigation { get; set; }

    public virtual Ticket Ticket { get; set; } = null!;
}
