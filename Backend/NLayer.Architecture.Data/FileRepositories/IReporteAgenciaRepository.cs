
using NLayer.Architecture.Bussines.ReporteAgencia;
using System.Net;

namespace DataAccess.Layer.FileRepositories;

public interface IReporteAgenciaRepository
{
    Task<List<Vehiculo>> GetVehiculos();
    Task AddVehiculo(Vehiculo vehiculo);
    Task<bool> UpdateVehiculo(IEnumerable<Vehiculo> vehiculo);
    Task<bool> DeleteVehiculo();

    Task<List<Cliente>> GetClientes();
    Task AddCliente(Cliente cliente);
    Task<bool> UpdateCliente(IEnumerable<Cliente> cliente);
    Task<bool> DeleteCliente();

}
