using HospitalAppointmentSystem.Models;
using HospitalAppointmentSystem.Models.Dtos.Appointments.Request;
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


    public string CreateAppointment(AppointmentDto appointmentDto)
    {
        // Boş alan kontrolü
        if (string.IsNullOrEmpty(appointmentDto.PatientName))
        {
            return "Hasta ismi boş olamaz!";
        }

        // 3 gün sonrası kontrolü
        if (!_appointmentRepository.IsValidAppointmentDate(appointmentDto.AppointmentDate))
        {
            return "Randevu tarihi bugünden en az 3 gün sonrası olmalıdır.";
        }

        // DTO'yu entity'ye çevir
        var appointment = new Appointment
        {
            PatientName = appointmentDto.PatientName,
            AppointmentDate = appointmentDto.AppointmentDate,
            DoctorId = appointmentDto.DoctorId
        };

        // Randevuyu kaydet
        _appointmentRepository.Add(appointment);

        return "Randevu başarıyla oluşturuldu.";
    }

}
