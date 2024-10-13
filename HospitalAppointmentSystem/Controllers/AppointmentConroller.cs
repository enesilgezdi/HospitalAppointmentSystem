using HospitalAppointmentSystem.Models;
using HospitalAppointmentSystem.Models.Dtos.Appointments.Request;
using HospitalAppointmentSystem.Services.Abstracts;
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

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = _appointmentsService.GetAll();
        return Ok(result);
    }

    [HttpPost("add")]
    public IActionResult Add(Appointment appointment)
    {
        var result = _appointmentsService.Add(appointment);
        return Ok(result);
    }

    [HttpDelete("delete")]
    public IActionResult Delete(int id) 
    {
        var result = _appointmentsService.Delete(id);
        return Ok(result);
    }

    [HttpGet("getbyid")]
    public IActionResult GetById(int id) 
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

    [HttpPost]
    public IActionResult Create(AppointmentDto appointmentDto)
    {
        // Servisi çağır
        var result = _appointmentsService.CreateAppointment(appointmentDto);

        // Eğer hata varsa, BadRequest döneriz
        if (result != "Randevu başarıyla oluşturuldu.")
        {
            return BadRequest(result);
        }

        return Ok(result);
    }
}
