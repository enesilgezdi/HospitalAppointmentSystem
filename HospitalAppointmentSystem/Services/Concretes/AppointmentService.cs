using HospitalAppointmentSystem.Models;
using HospitalAppointmentSystem.Repository.Abstracts;
using HospitalAppointmentSystem.ReturnModels;
using HospitalAppointmentSystem.Services.Abstracts;

namespace HospitalAppointmentSystem.Services.Concretes;

public class AppointmentService : IAppointmentService
{
    private IAppointmentRepository _appointmentRepository;

    public AppointmentService(IAppointmentRepository appointmentRepository)
    {
        _appointmentRepository = appointmentRepository;
    }
    public ReturnModels<Appointment> Add(Appointment appointment)
    {
        DateTime today = DateTime.Now;
        if(appointment.AppointmentDate< today.AddDays(3))
        {
            return new ReturnModels<Appointment>
            {
                Data = null,
                success = false,
                Message = "En az 3 gün sonrasına randevu alabilirsiniz"
            };
        }

        if (appointment.DoctorId == 0)// buraya id kontrolü nasıl eklerim ilgili id yok ise mesela
        {
            return new ReturnModels<Appointment>
            {
                Data = null,
                success = false,
                Message = "Doktor id kısmı boş bırakılamaz."
            };
        }
        if (appointment.PatientName is null || appointment.PatientName == "")
        {
            return new ReturnModels<Appointment>
            {
                Data = null,
                success = false,
                Message = "Hasta isim alanı boş bırakılamaz."
            };
        }

        var existingAppointments = _appointmentRepository.GetAppointmentsByDoctorId(appointment.DoctorId);
        if (existingAppointments.Count >= 10)
        {
            return new ReturnModels<Appointment>
            {
                Data = null,
                success = false,
                Message = "Bu doktor için en fazla 10 randevu oluşturulabilir."
            };
        }

        return new ReturnModels<Appointment>
        {

            Data = _appointmentRepository.Add(appointment),
            success = true,
            Message = "Randevu başarıyla oluşturuldu."
        };

    }

    public Appointment Delete(Guid id)
    {
        Appointment appointment = _appointmentRepository.Delete(id);
        return appointment;
    }

    public List<Appointment> GetAll()
    {
        return _appointmentRepository.GetAll();
    }

    public Appointment? GetById(Guid id)
    {
        Appointment appointment = _appointmentRepository.GetById(id);
        return appointment;
    }

    public void DeleteExpired()
    {
        var result = _appointmentRepository.GetAll().Where(x => x.AppointmentDate < DateTime.Now).ToList();
        foreach (var appointment in result)
        {
            _appointmentRepository.Delete(appointment.Id);
        }
    }

    public Appointment Uptdate(Appointment appointment)
    {
        Appointment updated = _appointmentRepository.Uptdate(appointment);
        return updated;
    }

   
}
