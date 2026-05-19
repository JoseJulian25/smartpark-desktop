using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using SmartPark.Data.Modelos;

namespace SmartPark.UI.Services
{
    public class TicketPdfService
    {
        private readonly string _outputDir;

        public TicketPdfService()
        {
            _outputDir = Path.Combine(Path.GetTempPath(), "SmartPark");
        }

        public string CrearTicketPdf(Ticket ticket)
        {
            if (ticket == null)
            {
                throw new ArgumentNullException(nameof(ticket));
            }

            EnsureOutputDir();
            var fileName = $"ticket_{SafeFilePart(ticket.CodigoTicket)}_{DateTime.Now:yyyyMMddHHmmssfff}.pdf";
            var filePath = Path.Combine(_outputDir, fileName);

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A6);
                    page.Margin(22);
                    page.DefaultTextStyle(x => x.FontSize(10));

                    page.Content().Element(container =>
                    {
                        container
                            .Border(1)
                            .BorderColor(Colors.Grey.Lighten2)
                            .Padding(12)
                            .Column(column =>
                            {
                                column.Spacing(6);
                                column.Item().Element(c => ComposeHeader(c, "Ticket de entrada", ticket.HoraEntrada));
                                column.Item().Element(ComposeDivider);
                                column.Item().Element(c => ComposeKeyValueTable(c, new[]
                                {
                                    ("Ticket", NormalizeText(ticket.CodigoTicket)),
                                    ("Placa", NormalizeText(ticket.Placa)),
                                    ("Tipo", NormalizeText(ticket.Espacio?.TipoVehiculo?.Nombre ?? "N/A")),
                                    ("Espacio", NormalizeText(ticket.Espacio?.CodigoEspacio ?? "N/A")),
                                    ("Entrada", ticket.HoraEntrada.ToString("dd/MM/yyyy HH:mm"))
                                }));
                                column.Item().Element(ComposeDivider);
                                column.Item().AlignCenter().Text("Conserve este ticket para la salida")
                                    .FontSize(9).FontColor(Colors.Grey.Darken2);
                            });
                    });
                });
            }).GeneratePdf(filePath);

            return filePath;
        }

        public string CrearPagoPdf(Ticket ticket, Pago pago)
        {
            if (ticket == null)
            {
                throw new ArgumentNullException(nameof(ticket));
            }

            if (pago == null)
            {
                throw new ArgumentNullException(nameof(pago));
            }

            EnsureOutputDir();
            var fileName = $"factura_{SafeFilePart(ticket.CodigoTicket)}_{DateTime.Now:yyyyMMddHHmmssfff}.pdf";
            var filePath = Path.Combine(_outputDir, fileName);
            var cambio = Math.Max(0m, pago.MontoRecibido - pago.Monto);

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A6);
                    page.Margin(22);
                    page.DefaultTextStyle(x => x.FontSize(10));

                    page.Content().Element(container =>
                    {
                        container
                            .Border(1)
                            .BorderColor(Colors.Grey.Lighten2)
                            .Padding(12)
                            .Column(column =>
                            {
                                column.Spacing(6);
                                column.Item().Element(c => ComposeHeader(c, "Factura de cobro", pago.HoraPago));
                                column.Item().Element(ComposeDivider);
                                column.Item().Element(c => ComposeKeyValueTable(c, new[]
                                {
                                    ("Ticket", NormalizeText(ticket.CodigoTicket)),
                                    ("Placa", NormalizeText(ticket.Placa)),
                                    ("Entrada", ticket.HoraEntrada.ToString("dd/MM/yyyy HH:mm")),
                                    ("Salida", ticket.HoraSalida?.ToString("dd/MM/yyyy HH:mm") ?? "N/A"),
                                    ("Tiempo", FormatDuration(ticket.HoraEntrada, ticket.HoraSalida)),
                                    ("Metodo", NormalizeText(pago.MetodoPago))
                                }));
                                column.Item().Element(ComposeDivider);
                                column.Item().Element(c => ComposeAmountBox(c, pago.Monto, pago.MontoRecibido, cambio));
                                column.Item().AlignCenter().Text("Gracias por su visita")
                                    .FontSize(9).FontColor(Colors.Grey.Darken2);
                            });
                    });
                });
            }).GeneratePdf(filePath);

            return filePath;
        }

        public void AbrirPdf(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentException("Ruta de archivo no valida.", nameof(filePath));
            }

            var startInfo = new ProcessStartInfo
            {
                FileName = filePath,
                UseShellExecute = true
            };

            Process.Start(startInfo);
        }

        private void EnsureOutputDir()
        {
            if (!Directory.Exists(_outputDir))
            {
                Directory.CreateDirectory(_outputDir);
            }
        }

        private static void ComposeHeader(IContainer container, string subtitle, DateTime fecha)
        {
            container.Row(row =>
            {
                row.RelativeItem().Column(col =>
                {
                    col.Item().Text("SmartPark").FontSize(16).SemiBold();
                    col.Item().Text(subtitle).FontSize(11).FontColor(Colors.Grey.Darken2);
                });

                row.ConstantItem(90).AlignRight().Text(text =>
                {
                    text.Line("Fecha").FontSize(8).FontColor(Colors.Grey.Darken2);
                    text.Line(fecha.ToString("dd/MM/yyyy")).FontSize(9).SemiBold();
                    text.Line(fecha.ToString("HH:mm")).FontSize(9).SemiBold();
                });
            });
        }

        private static void ComposeDivider(IContainer container)
        {
            container.LineHorizontal(1).LineColor(Colors.Grey.Lighten2);
        }

        private static void ComposeKeyValueTable(IContainer container, (string Label, string Value)[] items)
        {
            container.Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn(1);
                    columns.RelativeColumn(2);
                });

                foreach (var item in items)
                {
                    table.Cell().Element(CellLabel).Text(item.Label);
                    table.Cell().Element(CellValue).Text(item.Value);
                }
            });
        }

        private static IContainer CellLabel(IContainer container)
        {
            return container
                .PaddingVertical(2)
                .AlignLeft()
                .DefaultTextStyle(x => x.FontSize(9).FontColor(Colors.Grey.Darken2));
        }

        private static IContainer CellValue(IContainer container)
        {
            return container
                .PaddingVertical(2)
                .AlignRight()
                .DefaultTextStyle(x => x.FontSize(9).SemiBold());
        }

        private static void ComposeAmountBox(IContainer container, decimal monto, decimal recibido, decimal cambio)
        {
            container
                .Background(Colors.Grey.Lighten4)
                .Border(1)
                .BorderColor(Colors.Grey.Lighten2)
                .Padding(8)
                .Column(column =>
                {
                    column.Spacing(4);
                    column.Item().Row(row =>
                    {
                        row.RelativeItem().Text("Total").SemiBold();
                        row.ConstantItem(80).AlignRight().Text(monto.ToString("0.00")).SemiBold();
                    });
                    column.Item().Row(row =>
                    {
                        row.RelativeItem().Text("Recibido");
                        row.ConstantItem(80).AlignRight().Text(recibido.ToString("0.00"));
                    });
                    column.Item().Row(row =>
                    {
                        row.RelativeItem().Text("Cambio");
                        row.ConstantItem(80).AlignRight().Text(cambio.ToString("0.00"));
                    });
                });
        }

        private static string FormatDuration(DateTime inicio, DateTime? fin)
        {
            if (!fin.HasValue)
            {
                return "N/A";
            }

            var total = fin.Value - inicio;
            if (total.TotalMinutes < 0)
            {
                return "0h 0m";
            }

            var horas = (int)total.TotalHours;
            var minutos = total.Minutes;
            return $"{horas}h {minutos}m";
        }

        private static string NormalizeText(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return "N/A";
            }

            var cleaned = new string(value.Select(c => char.IsControl(c) ? ' ' : c).ToArray());
            return string.Join(" ", cleaned.Split(' ', StringSplitOptions.RemoveEmptyEntries));
        }

        private static string SafeFilePart(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return "ticket";
            }

            var invalidChars = Path.GetInvalidFileNameChars();
            var sanitized = new string(value.Select(c => invalidChars.Contains(c) ? '_' : c).ToArray());
            return string.IsNullOrWhiteSpace(sanitized) ? "ticket" : sanitized;
        }
    }
}
