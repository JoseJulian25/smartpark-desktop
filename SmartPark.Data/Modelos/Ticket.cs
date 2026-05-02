using System;
using System.Collections.Generic;

namespace SmartPark.Data.Modelos;

public partial class Ticket
{
    public long Id { get; set; }

    public string CodigoTicket { get; set; } = null!;

    public DateTime? FechaCreacion { get; set; }

    public DateTime HoraEntrada { get; set; }

    public DateTime? HoraSalida { get; set; }

    public decimal? MontoTotal { get; set; }

    public string Placa { get; set; } = null!;

    public long? CreadoPor { get; set; }

    public long EspacioId { get; set; }

    public int EstadoId { get; set; }

    public int TipoVehiculoId { get; set; }

    public virtual Usuario? CreadoPorNavigation { get; set; }

    public virtual Espacio Espacio { get; set; } = null!;

    public virtual EstadosTicket Estado { get; set; } = null!;

    public virtual Pago? Pago { get; set; }

    public virtual TiposVehiculo TipoVehiculo { get; set; } = null!;
}
