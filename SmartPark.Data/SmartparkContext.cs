using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SmartPark.Data.Modelos;

namespace SmartPark.Data;

public partial class SmartparkContext : DbContext
{
    public SmartparkContext()
    {
    }

    public SmartparkContext(DbContextOptions<SmartparkContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<Espacio> Espacios { get; set; }

    public virtual DbSet<EstadosEspacio> EstadosEspacios { get; set; }

    public virtual DbSet<EstadosReserva> EstadosReservas { get; set; }

    public virtual DbSet<EstadosTicket> EstadosTickets { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<Reserva> Reservas { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Tarifa> Tarifas { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<TiposVehiculo> TiposVehiculos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=smartpark;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("empresas_pkey");

            entity.ToTable("empresas");

            entity.HasIndex(e => e.Email, "UQ__empresas__AB6E616462FB610F").IsUnique();

            entity.HasIndex(e => e.Rnc, "UQ__empresas__C2B7F58EFF00778C").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Rnc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("rnc");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Espacio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("espacios_pkey");

            entity.ToTable("espacios");

            entity.HasIndex(e => e.CodigoEspacio, "UQ__espacios__D650181D64CA84C7").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.CodigoEspacio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("codigo_espacio");
            entity.Property(e => e.EstadoId).HasColumnName("estado_id");
            entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");
            entity.Property(e => e.TipoVehiculoId).HasColumnName("tipo_vehiculo_id");

            entity.HasOne(d => d.Estado).WithMany(p => p.Espacios)
                .HasForeignKey(d => d.EstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_espacios_estado");

            entity.HasOne(d => d.TipoVehiculo).WithMany(p => p.Espacios)
                .HasForeignKey(d => d.TipoVehiculoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_espacios_tipo_vehiculo");
        });

        modelBuilder.Entity<EstadosEspacio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("estados_espacio_pkey");

            entity.ToTable("estados_espacio");

            entity.HasIndex(e => e.Nombre, "UQ__estados___72AFBCC62C49DF6A").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<EstadosReserva>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("estados_reserva_pkey");

            entity.ToTable("estados_reserva");

            entity.HasIndex(e => e.Nombre, "UQ__estados___72AFBCC6BC47873F").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<EstadosTicket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("estados_ticket_pkey");

            entity.ToTable("estados_ticket");

            entity.HasIndex(e => e.Nombre, "UQ__estados___72AFBCC662B440DA").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pagos_pkey");

            entity.ToTable("pagos");

            entity.HasIndex(e => e.TicketId, "UQ__pagos__D596F96A62E8B40F").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.HoraPago).HasColumnName("hora_pago");
            entity.Property(e => e.MetodoPago)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("metodo_pago");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("monto");
            entity.Property(e => e.MontoRecibido)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("monto_recibido");
            entity.Property(e => e.ProcesadoPor).HasColumnName("procesado_por");
            entity.Property(e => e.TicketId).HasColumnName("ticket_id");

            entity.HasOne(d => d.ProcesadoPorNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.ProcesadoPor)
                .HasConstraintName("fk_pagos_usuario");

            entity.HasOne(d => d.Ticket).WithOne(p => p.Pago)
                .HasForeignKey<Pago>(d => d.TicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pagos_ticket");
        });

        modelBuilder.Entity<Reserva>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("reservas_pkey");

            entity.ToTable("reservas");

            entity.HasIndex(e => e.CodigoReserva, "UQ__reservas__0F189A434262B837").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CanceladoPor).HasColumnName("cancelado_por");
            entity.Property(e => e.ClienteEmail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("cliente_email");
            entity.Property(e => e.ClienteNombreCompleto)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("cliente_nombre_completo");
            entity.Property(e => e.ClienteTelefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cliente_telefono");
            entity.Property(e => e.CodigoReserva)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("codigo_reserva");
            entity.Property(e => e.CreadoPor).HasColumnName("creado_por");
            entity.Property(e => e.EspacioId).HasColumnName("espacio_id");
            entity.Property(e => e.EstadoId).HasColumnName("estado_id");
            entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");
            entity.Property(e => e.HoraFin).HasColumnName("hora_fin");
            entity.Property(e => e.HoraInicio).HasColumnName("hora_inicio");
            entity.Property(e => e.MotivoCancelacion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("motivo_cancelacion");
            entity.Property(e => e.Placa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("placa");
            entity.Property(e => e.TipoVehiculoId).HasColumnName("tipo_vehiculo_id");

            entity.HasOne(d => d.CanceladoPorNavigation).WithMany(p => p.ReservaCanceladoPorNavigations)
                .HasForeignKey(d => d.CanceladoPor)
                .HasConstraintName("fk_reservas_cancelado");

            entity.HasOne(d => d.CreadoPorNavigation).WithMany(p => p.ReservaCreadoPorNavigations)
                .HasForeignKey(d => d.CreadoPor)
                .HasConstraintName("fk_reservas_creado");

            entity.HasOne(d => d.Espacio).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.EspacioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_reservas_espacio");

            entity.HasOne(d => d.Estado).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.EstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_reservas_estado");

            entity.HasOne(d => d.TipoVehiculo).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.TipoVehiculoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_reservas_tipo");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roles_pkey");

            entity.ToTable("roles");

            entity.HasIndex(e => e.Nombre, "UQ__roles__72AFBCC63610B551").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Tarifa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tarifas_pkey");

            entity.ToTable("tarifas");

            entity.HasIndex(e => e.TipoVehiculoId, "UQ__tarifas__3A65348B7071D4A5").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActualizadoEn).HasColumnName("actualizado_en");
            entity.Property(e => e.MinutosFraccion).HasColumnName("minutos_fraccion");
            entity.Property(e => e.MinutosMinimo).HasColumnName("minutos_minimo");
            entity.Property(e => e.MinutosTolerancia).HasColumnName("minutos_tolerancia");
            entity.Property(e => e.PrecioPorFraccion)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("precio_por_fraccion");
            entity.Property(e => e.TipoVehiculoId).HasColumnName("tipo_vehiculo_id");

            entity.HasOne(d => d.TipoVehiculo).WithOne(p => p.Tarifa)
                .HasForeignKey<Tarifa>(d => d.TipoVehiculoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tarifas_tipo");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tickets_pkey");

            entity.ToTable("tickets");

            entity.HasIndex(e => e.CodigoTicket, "UQ__tickets__4FFCECF65A0BBB23").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodigoTicket)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("codigo_ticket");
            entity.Property(e => e.CreadoPor).HasColumnName("creado_por");
            entity.Property(e => e.EspacioId).HasColumnName("espacio_id");
            entity.Property(e => e.EstadoId).HasColumnName("estado_id");
            entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");
            entity.Property(e => e.HoraEntrada).HasColumnName("hora_entrada");
            entity.Property(e => e.HoraSalida).HasColumnName("hora_salida");
            entity.Property(e => e.MontoTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("monto_total");
            entity.Property(e => e.Placa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("placa");
            entity.Property(e => e.TipoVehiculoId).HasColumnName("tipo_vehiculo_id");

            entity.HasOne(d => d.CreadoPorNavigation).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.CreadoPor)
                .HasConstraintName("fk_tickets_usuario");

            entity.HasOne(d => d.Espacio).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.EspacioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tickets_espacio");

            entity.HasOne(d => d.Estado).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.EstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tickets_estado");

            entity.HasOne(d => d.TipoVehiculo).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.TipoVehiculoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tickets_tipo");
        });

        modelBuilder.Entity<TiposVehiculo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tipos_vehiculo_pkey");

            entity.ToTable("tipos_vehiculo");

            entity.HasIndex(e => e.Nombre, "UQ__tipos_ve__72AFBCC6BB21AE30").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("usuarios_pkey");

            entity.ToTable("usuarios");

            entity.HasIndex(e => e.Username, "UQ__usuarios__F3DBC5720B372352").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Eliminado).HasColumnName("eliminado");
            entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");
            entity.Property(e => e.FechaEliminacion).HasColumnName("fecha_eliminacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.RolId).HasColumnName("rol_id");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("username");

            entity.HasOne(d => d.Rol).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.RolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_usuarios_rol");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
