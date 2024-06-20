

namespace NLayer.Architecture.Bussines.ReporteAgencia;

public class ReporteAgencia
{
    public string Nombre { get; set; } = "Reporte agencia de auto";
    public DateOnly Date => DateOnly.FromDateTime( DateTime.Now);

    public List<Cliente> Cliente { get; set; }

    public List<Vehiculo> Vehiculo { get; set; }

    public List<Ventas> Ventas { get; set; }
}
