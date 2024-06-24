
using NLayer.Architecture.Bussines.ReporteAgencia;

namespace NLayer.Architecture.Bussines.Services;

public interface IReporteAgenciaServices
{
    Task<ReporteAgencia.ReporteAgencia> GetReporteAgencia();

    Task AddVehiculo(Vehiculo vehiculo);
    Task<bool> UpdateVehiculo(IEnumerable<Vehiculo> vehiculo);
    Task<bool> DeleteVehiculo();

    Task AddCliente(Cliente cliente);
    Task<bool> UpdateCliente(IEnumerable<Cliente> cliente);
    Task<bool> DeleteCliente();

    Task AddVentas(Ventas ventas);
    Task<bool> UpdateVentas(IEnumerable<Ventas> ventas);
    Task<bool> DeleteVentas();
}
