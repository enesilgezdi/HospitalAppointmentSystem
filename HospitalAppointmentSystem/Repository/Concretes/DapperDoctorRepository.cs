using HospitalAppointmentSystem.Models;
using HospitalAppointmentSystem.Repository.Abstracts;

namespace HospitalAppointmentSystem.Repository.Concretes;

public class DapperDoctorRepository : IDoctorRepository
{
    public Doctor Add(Doctor doctor)
    {
        throw new NotImplementedException();
    }

    public Doctor Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Doctor> GetAll()
    {
        throw new NotImplementedException();
    }

    public List<Doctor> GetAllByAppointment(string text)
    {
        throw new NotImplementedException();
    }

    public Doctor? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Doctor Uptdate(Doctor doctor)
    {
        throw new NotImplementedException();
    }
}
