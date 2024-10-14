using HospitalAppointmentSystem.Models;

namespace HospitalAppointmentSystem.Repository.Abstracts;

public interface IAppointmentRepository :IEntityRepository<Appointment, Guid>
{
    List<Appointment> GetAppointmentsByDoctorId(int doctorId);
}
