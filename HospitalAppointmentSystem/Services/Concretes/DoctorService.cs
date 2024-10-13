using HospitalAppointmentSystem.Models;
using HospitalAppointmentSystem.Repository.Abstracts;
using HospitalAppointmentSystem.Services.Abstracts;

namespace HospitalAppointmentSystem.Services.Concretes;

public class DoctorService : IDoctorService
{
    private IDoctorRepository _doctorRepository;

    public DoctorService( IDoctorRepository doctorRepository)
    {
        _doctorRepository = doctorRepository;
    }
    public Doctor Add(Doctor doctor)
    {
        Doctor doctors = (Doctor)doctor;

        Doctor created = _doctorRepository.Add(doctor);

        return created;
    }

    public Doctor Delete(int id)
    {
        Doctor doctor = _doctorRepository.Delete(id);
        return doctor;
    }

    public List<Doctor> GetAll()
    {
        return _doctorRepository.GetAll();
    }

    public List<Doctor> GetAllByAppointment(string text)
    {
        throw new NotImplementedException();
    }

    public Doctor? GetById(int id)
    {
        Doctor doctor = _doctorRepository.GetById(id);
        return doctor;
    }

    public Doctor Uptdate(Doctor doctor)
    {
        Doctor updated = _doctorRepository.Uptdate(doctor);
        return updated;
    }
}
