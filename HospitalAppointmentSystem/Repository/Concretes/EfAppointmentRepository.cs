using HospitalAppointmentSystem.Context;
using HospitalAppointmentSystem.Models;
using HospitalAppointmentSystem.Repository.Abstracts;

namespace HospitalAppointmentSystem.Repository.Concretes;

public class EfAppointmentRepository : IAppointmentRepository
{
    private MsSqlContext _context;

    public EfAppointmentRepository(MsSqlContext context)
    {
        _context = context;
    }
    public Appointment Add(Appointment appointment)
    {
        _context.Appointments.Add(appointment);
        _context.SaveChanges();
        return appointment;
    }

    public Appointment Delete(Guid id)
    {
        Appointment appointment = GetById(id);
        _context.Appointments.Remove(appointment);
        _context.SaveChanges();
        return appointment;
    }

    public List<Appointment> GetAll()
    {
        _context.SaveChanges();
        return _context.Appointments.ToList();
    }

    public List<Appointment> GetAppointmentsByDoctorId(int doctorId)
    {
        return _context.Appointments.Where(x=>x.DoctorId == doctorId).ToList();
    }

    public Appointment? GetById(Guid id)
    {
        Appointment? appointment = _context.Appointments.Find(id);
        return appointment;
    }

    public Appointment Uptdate(Appointment appointment)
    {
        _context.Appointments.Update(appointment);
        _context.SaveChanges();
        return appointment;
    }
  
   

}
