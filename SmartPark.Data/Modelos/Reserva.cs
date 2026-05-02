using System;
using System.Collections.Generic;

namespace SmartPark.Data.Modelos;

public partial class Reserva
{
    public long Id { get; set; }

    public string ClienteEmail { get; set; } = null!;

    public string ClienteNombreCompleto { get; set; } = null!;

    public string ClienteTelefono { get; set; } = null!;

    public string CodigoReserva { get; set; } = null!;

    public DateTime? FechaCreacion { get; set; }

    public DateTime? HoraFin { get; set; }

    public DateTime HoraInicio { get; set; }

    public string? MotivoCancelacion { get; set; }

    public string Placa { get; set; } = null!;

    public long? CanceladoPor { get; set; }

    public long? CreadoPor { get; set; }

    public long EspacioId { get; set; }

    public int EstadoId { get; set; }

    public int TipoVehiculoId { get; set; }

    public virtual Usuario? CanceladoPorNavigation { get; set; }

    public virtual Usuario? CreadoPorNavigation { get; set; }

    public virtual Espacio Espacio { get; set; } = null!;

    public virtual EstadosReserva Estado { get; set; } = null!;

    public virtual TiposVehiculo TipoVehiculo { get; set; } = null!;
}
