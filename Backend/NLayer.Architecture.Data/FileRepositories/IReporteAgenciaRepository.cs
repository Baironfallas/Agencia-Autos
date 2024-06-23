
using NLayer.Architecture.Bussines.ReporteAgencia;

namespace DataAccess.Layer.FileRepositories;

public interface IReporteAgenciaRepository
{
    Task<List<Vehiculo>> GetVehiculos();
    Task AddVehiculo(Vehiculo vehiculo);
    Task<bool> UpdateVehiculo(IEnumerable<Vehiculo> vehiculo);
    Task<bool> DeleteVehiculo();
}
