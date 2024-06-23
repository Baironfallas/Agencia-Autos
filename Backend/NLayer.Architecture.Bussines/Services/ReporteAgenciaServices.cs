using DataAccess.Layer.FileRepositories;
using NLayer.Architecture.Bussines.ReporteAgencia;

namespace NLayer.Architecture.Bussines.Services;

public class ReporteAgenciaServices : IReporteAgenciaServices
{

    private IReporteAgenciaRepository _reporteAgencia;

    public ReporteAgenciaServices(IReporteAgenciaRepository reporteAgencia)
    {
        _reporteAgencia = reporteAgencia;
    }
    public async Task<ReporteAgencia.ReporteAgencia> GetReporteAgencia()
    {
        ReporteAgencia.ReporteAgencia miReporteAgencia = new ReporteAgencia.ReporteAgencia();
        miReporteAgencia.Vehiculo = await _reporteAgencia.GetVehiculos();
        
        return miReporteAgencia;
    }
    public async Task AddVehiculo(Vehiculo vehiculo)
    {
        await _reporteAgencia.AddVehiculo(vehiculo);
    }
    public async Task<bool> UpdateVehiculo(IEnumerable<Vehiculo> vehiculo)
    {
         return await _reporteAgencia.UpdateVehiculo(vehiculo);
    }
    public async Task<bool> DeleteVehiculo()
    {
        return await _reporteAgencia.DeleteVehiculo();
    }
}
//private readonly IReporteAgenciaRepository _reporteAgencia es una campo de lectura el cual me sirve para acceder a los metodos que hay en esa clase y a su vez me permite hacer la inyeccion de dependencia.