using HospitalAppointmentSystem.Models;

namespace HospitalAppointmentSystem.Repository.Abstracts;

public interface IDoctorRepository : IEntityRepository<Doctor>
{

    List<Doctor> GetAllByAppointment(string text);
}
