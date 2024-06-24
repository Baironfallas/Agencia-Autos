
using Microsoft.AspNetCore.Mvc;
using NLayer.Architecture.Bussines.ReporteAgencia;
using NLayer.Architecture.Bussines.Services;

namespace NLayer.Architecture.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ReporteAgenciaAutoController : ControllerBase
{
    private readonly IReporteAgenciaServices _reporteAgenciaServices;

    public ReporteAgenciaAutoController(IReporteAgenciaServices reporteAgenciaServices)
    {
        _reporteAgenciaServices = reporteAgenciaServices;
    }
    [HttpGet]
    public async Task<ReporteAgencia> Get()
    {
        return await _reporteAgenciaServices.GetReporteAgencia();
    }


    [HttpPost("AddVehiculo",Name ="AddVehiculo")]
    public async Task AddVehiculo(Vehiculo vehiculo)
    {
         await _reporteAgenciaServices.AddVehiculo(vehiculo);
    }

    [HttpPut("UpdateVehiculo",Name ="UpdateVehiculo")]
    public async Task<IActionResult> UpdateVehiculo(IEnumerable<Vehiculo> Updatevehiculo)
    {
        return await _reporteAgenciaServices.UpdateVehiculo(Updatevehiculo) ? Ok() : NotFound();
    }
    [HttpDelete("DeleteVehiculo", Name = "DeleteVehiculo")]
    public async Task <IActionResult> DeleteVehiculo()
    {
        return await _reporteAgenciaServices.DeleteVehiculo() ? Ok() : NotFound();
    }
    [HttpPost("AddCliente",Name ="AddCliente")]
    public async Task Add(Cliente cliente)
    {
        await _reporteAgenciaServices.AddCliente(cliente);
    }
    [HttpPut("UpdateCliente", Name = "UpdateCliente")]
    public async Task<IActionResult> UpdateCliente(IEnumerable<Cliente> updateCliente)
    {
        return await _reporteAgenciaServices.UpdateCliente(updateCliente) ? Ok() : NotFound();
    }
    [HttpDelete("DeleteCliente", Name = "Cliente")]
    public async Task<IActionResult> DeleteCliente()
    {
        return await _reporteAgenciaServices.DeleteCliente() ? Ok() : NotFound();
    }
}
