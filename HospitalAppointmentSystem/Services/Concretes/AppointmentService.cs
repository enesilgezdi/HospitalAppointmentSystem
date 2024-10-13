using HospitalAppointmentSystem.Models;
using HospitalAppointmentSystem.Repository.Abstracts;
using HospitalAppointmentSystem.Services.Abstracts;

namespace HospitalAppointmentSystem.Services.Concretes;

public class AppointmentService : IAppointmentService
{
    private IAppointmentRepository _appointmentRepository;

    public AppointmentService(IAppointmentRepository appointmentRepository)
    {
        _appointmentRepository = appointmentRepository;
    }
    public Appointment Add(Appointment appointment)
    {
        Appointment created  = _appointmentRepository.Add(appointment);
        return created;
    }

    public Appointment Delete(int id)
    {
        Appointment appointment = _appointmentRepository.Delete(id);
        return appointment;
    }

    public List<Appointment> GetAll()
    {
        return _appointmentRepository.GetAll();
    }

    public Appointment? GetById(int id)
    {
        Appointment appointment = _appointmentRepository.GetById(id);
        return appointment;
    }

    public Appointment Uptdate(Appointment appointment)
    {
        Appointment updated = _appointmentRepository.Uptdate(appointment);
        return updated;
    }
}
