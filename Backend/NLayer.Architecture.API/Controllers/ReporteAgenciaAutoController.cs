
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
}
