
using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.ReporteAgencia;
using NLayer.Architecture.Data;

namespace DataAccess.Layer.FileRepositories;
public class ReporteAgenciaRepository: FileRepository,IReporteAgenciaRepository
{
    private string _VehiculoVirtualPath = "Vehiculos.Json";
    private string _ClienteVirtualPath = "Cliente.Json";
    private string _VentaVirtualPath = "Ventas.Json";

    private string FolderPath { get; set; }

    public ReporteAgenciaRepository(IConfiguration configuration)
    {
        FolderPath = $"{configuration["Folders:AgenciaAuto"]}";
        _VehiculoVirtualPath = FolderPath + _VehiculoVirtualPath;
        _ClienteVirtualPath = FolderPath + _ClienteVirtualPath;
        _VentaVirtualPath = FolderPath + _VentaVirtualPath;
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

    public async Task<List<Cliente>> GetClientes()
    {
        return await ReadJsonFileAsync<List<Cliente>>(_ClienteVirtualPath);
    }

    public async Task AddCliente(Cliente cliente)
    {
        List<Cliente> elementos = await ReadJsonFileAsync<List<Cliente>>(_ClienteVirtualPath);
        if(cliente != null)
        {
            elementos.Add(cliente);
            await WriteJsonFileAsync(_ClienteVirtualPath, elementos);
        }
    }
    public async Task<bool> UpdateCliente(IEnumerable<Cliente> cliente)
    {
        List<Cliente> elementos = cliente.ToList();
        try
        {
            await WriteJsonFileAsync(_ClienteVirtualPath, elementos);
            return true;
        }
        catch(Exception genericExecption)
        {
            return false;
        }
    }
    public async Task<bool> DeleteCliente()
    {
        List<Cliente> elementos = new();
        try
        {
            await WriteJsonFileAsync(_ClienteVirtualPath, elementos);
            return true;
        }
        catch(Exception genericExecption)
        {
            return false;
        }
    }

    public async Task<List<Ventas>> GetVentas()
    {
         return await ReadJsonFileAsync<List<Ventas>>(_VentaVirtualPath);
    }
    
    public async Task AddVentas(Ventas ventas)
    {
        List<Ventas> elementos = await ReadJsonFileAsync<List<Ventas>>(_VentaVirtualPath);
        if(elementos != null)
        {
            elementos.Add(ventas);
            await WriteJsonFileAsync(_ClienteVirtualPath, ventas);
        }
    }

    public async Task<bool> UpdateVentas(IEnumerable<Ventas> ventas)
    {
        List<Ventas> elementos = ventas.ToList();
        try
        {
            await WriteJsonFileAsync(_VentaVirtualPath, elementos);
            return true;
        }
        catch(Exception ex)
        {
            return false;
        }
    }

    public async Task<bool> DeleteVenta()
    {
        List<Ventas> elementos = new();
        try
        {
            await WriteJsonFileAsync(_ClienteVirtualPath, elementos);
            return true;
        }
        catch(Exception ex)
        {
            return false;
        }
    }
}
