using HospitalAppointmentSystem.Models;
using HospitalAppointmentSystem.Models.Dtos.Doctors.Request;
using HospitalAppointmentSystem.Repository.Abstracts;
using HospitalAppointmentSystem.ReturnModels;
using HospitalAppointmentSystem.Services.Abstracts;

namespace HospitalAppointmentSystem.Services.Concretes;

public class DoctorService : IDoctorService
{
    private IDoctorRepository _doctorRepository;

    public DoctorService( IDoctorRepository doctorRepository)
    {
        _doctorRepository = doctorRepository;
    }
    public ReturnModels<Doctor> Add(AddDoctorRequetDto dto)
    {
        if (dto.Name == null || dto.Name == "")
        {
            return new ReturnModels<Doctor>
            {
                Data = null,
                success = false,
                Message = "Doktor isim alanı boş bırakılamaz."
            };
        }
        Doctor doctor = (Doctor)dto;
        Doctor createdDoctor = _doctorRepository.Add(doctor);

        return new ReturnModels<Doctor>
        {
            Data = createdDoctor,
            success = true,
            Message = "Doktor Başarı ile eklendi."
        };

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

    
    public Doctor? GetById(int id)
    {
        Doctor doctor = _doctorRepository.GetById(id);
        return doctor;
    }

    public Doctor Uptdate(AddDoctorRequetDto dto)
    {
        Doctor doctor = (Doctor)dto;
        var updated = _doctorRepository.Uptdate(doctor);
        return updated;
    }
}
