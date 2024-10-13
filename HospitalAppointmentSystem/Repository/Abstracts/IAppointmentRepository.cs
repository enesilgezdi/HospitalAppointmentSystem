using HospitalAppointmentSystem.Models;

namespace HospitalAppointmentSystem.Repository.Abstracts;

public interface IAppointmentRepository :IEntityRepository<Appointment>
{

    bool IsValidAppointmentDate(DateTime appointmentDate);
    List<Appointment> GetAppointmentsForDoctor(int doctorId);
}
