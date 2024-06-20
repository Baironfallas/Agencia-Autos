
using NLayer.Architecture.Bussines.ReporteAgencia;

namespace NLayer.Architecture.Bussines.Services;

public interface IReporteAgenciaServices
{
    Task<ReporteAgencia.ReporteAgencia> GetReporteAgencia();

    Task AddVehiculo(Vehiculo vehiculo);
    Task<bool> UpdateVehiculo(IEnumerable<Vehiculo> vehiculo);

    Task<bool> DeleteVehiculo();
}
