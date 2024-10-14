using HospitalAppointmentSystem.Models;

namespace HospitalAppointmentSystem.Services.Abstracts;
using HospitalAppointmentSystem.ReturnModels;

public interface IAppointmentService
{

    ReturnModels<Appointment> Add(Appointment appointment);

    Appointment Delete(Guid id);

    List<Appointment> GetAll();


    Appointment? GetById(Guid id);


    Appointment Uptdate(Appointment appointment);

    void DeleteExpired();

}
