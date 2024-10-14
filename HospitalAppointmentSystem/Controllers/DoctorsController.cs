using HospitalAppointmentSystem.Models;
using HospitalAppointmentSystem.Models.Dtos.Doctors.Request;
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

    [HttpDelete("delete")]
    public IActionResult Delete(int id)
    {
        var result = _doctorService.Delete(id);
        return Ok(result);
    }

    [HttpPut("update")]
    public IActionResult Update(AddDoctorRequetDto updatedDoctor)
    {
        var result = _doctorService.Uptdate(updatedDoctor);
        return Ok(result);
    }

    [HttpPost("add")]
    public IActionResult Add(AddDoctorRequetDto doctor)
    {
        var result = _doctorService.Add(doctor);
        if(!result.success)
        {
            return BadRequest(new
            {
                Status=400,
                message= result.Message
            });

        }
        return Ok(result);
    }

    [HttpGet("getbyid")]
    public IActionResult GetById(int id) 
    {
        var result = _doctorService.GetById(id);
        return Ok(result);
    }
}
