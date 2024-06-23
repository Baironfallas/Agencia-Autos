
using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.ReporteAgencia;
using NLayer.Architecture.Data;

namespace DataAccess.Layer.FileRepositories;
public class ReporteAgenciaRepository: FileRepository,IReporteAgenciaRepository
{
    private string _VehiculoVirtualPath = "Vehiculos.Json";

    private string FolderPath { get; set; }

    public ReporteAgenciaRepository(IConfiguration configuration)
    {
        FolderPath = $"{configuration["Folders:AgenciaAuto"]}";
        _VehiculoVirtualPath = FolderPath + _VehiculoVirtualPath;
    }


    public async Task<List<Vehiculo>> GetVehiculos()
    {
        return await ReadJsonFileAsync<List<Vehiculo>>(_VehiculoVirtualPath);
    }


    public async Task AddVehiculo(Vehiculo vehiculo)
    {
        List<Vehiculo> elementos = await ReadJsonFileAsync<List<Vehiculo>>(_VehiculoVirtualPath);
        if (elementos != null)
        {
            elementos.Add(vehiculo);
            await WriteJsonFileAsync(_VehiculoVirtualPath, elementos);
        }
    }
    public async Task<bool> UpdateVehiculo(IEnumerable<Vehiculo> vehiculo)
    {
        List<Vehiculo> elementos = vehiculo.ToList();
        try
        {
            await WriteJsonFileAsync(_VehiculoVirtualPath, elementos);
                return true;
            
        }catch(Exception genericException)
        {
            return false;
        }
    }
    public async Task<bool> DeleteVehiculo()
    {
        List<Vehiculo> elementos = new();
        try
        {
            await WriteJsonFileAsync(_VehiculoVirtualPath, elementos);
            return true;
        }catch(Exception genericExecption)
        {
            return false;
        }
    }
}
