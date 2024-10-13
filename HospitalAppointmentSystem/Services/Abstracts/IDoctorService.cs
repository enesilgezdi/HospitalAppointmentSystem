using HospitalAppointmentSystem.Models;

namespace HospitalAppointmentSystem.Services.Abstracts;

public interface IDoctorService
{
    Doctor Add(Doctor doctor);


    Doctor Delete(int id);

    List<Doctor> GetAll();


    List<Doctor> GetAllByAppointment(string text);


    Doctor? GetById(int id);


    Doctor Uptdate(Doctor doctor);
    

}
