using HospitalAppointmentSystem.Models;

namespace HospitalAppointmentSystem.Services.Abstracts;

public interface IAppointmentService
{
    Appointment Add(Appointment appointment);

    Appointment Delete(int id);

    List<Appointment> GetAll();


    Appointment? GetById(int id);


    Appointment Uptdate(Appointment appointment);
}
