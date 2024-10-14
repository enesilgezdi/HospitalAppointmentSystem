using HospitalAppointmentSystem.Models;
using HospitalAppointmentSystem.Services.Abstracts;
using HospitalAppointmentSystem.Services.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace HospitalAppointmentSystem.Controllers;


[Route("api/[controller]")]
[ApiController]
public class AppointmentConroller : ControllerBase
{
    private IAppointmentService _appointmentsService;
    public AppointmentConroller(IAppointmentService appointmentService)
    {
        _appointmentsService = appointmentService;
    }


    
    [HttpGet("getallappointments")]
    public IActionResult GetAll()
    {
        var result = _appointmentsService.GetAll();
        _appointmentsService.DeleteExpired();
        return Ok(result);
    }


    [HttpPost("add")]
    public IActionResult Add(Appointment appointment)
    {
        var result = _appointmentsService.Add(appointment);
        if (!result.success)
        {
            return BadRequest(new
            {
                StatusCode = 400,
                message = result.Message
            });
        }
        return Ok(result);
    }

    [HttpDelete("delete")]
    public IActionResult Delete(Guid id) 
    {
        var result = _appointmentsService.Delete(id);
        return Ok(result);
    }

    [HttpGet("getbyid")]
    public IActionResult GetById(Guid id) 
    { 
        var result = _appointmentsService.GetById(id);
        return Ok(result);
    }

    [HttpGet("update")]
    public IActionResult Update(Appointment appointment)
    {
        var result = _appointmentsService.Uptdate(appointment);
        return Ok(result);
    }

  
}
