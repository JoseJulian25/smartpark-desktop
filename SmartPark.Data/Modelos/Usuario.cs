using System;
using System.Collections.Generic;

namespace SmartPark.Data.Modelos;

public partial class Usuario
{
    public long Id { get; set; }

    public bool Activo { get; set; }

    public bool Eliminado { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public string Nombre { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Username { get; set; } = null!;

    public int RolId { get; set; }

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();

    public virtual ICollection<Reserva> ReservaCanceladoPorNavigations { get; set; } = new List<Reserva>();

    public virtual ICollection<Reserva> ReservaCreadoPorNavigations { get; set; } = new List<Reserva>();

    public virtual Role Rol { get; set; } = null!;

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
