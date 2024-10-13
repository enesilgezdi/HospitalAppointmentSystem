using HospitalAppointmentSystem.Models;
using HospitalAppointmentSystem.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace HospitalAppointmentSystem.Controllers;

public class DoctorsController : ControllerBase
{
    private IDoctorService _doctorService;
    public DoctorsController(IDoctorService doctorService)
    {
        _doctorService = doctorService;
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = _doctorService.GetAll();
        return Ok(result);
    }

    [HttpGet("delete")]
    public IActionResult Delete(int id)
    {
        var result = _doctorService.Delete(id);
        return Ok(result);
    }

    [HttpGet("update")]
    public IActionResult Update(Doctor doctor)
    {
        var result = _doctorService.Uptdate(doctor);
        return Ok(result);
    }

    [HttpPost("add")]
    public IActionResult Add(Doctor doctor)
    {
        var result = _doctorService.Add(doctor);
        return Ok(result);
    }

    [HttpGet("getbyid")]
    public IActionResult GetById(int id) 
    {
        var result = _doctorService.GetById(id);
        return Ok(result);
    }
}
