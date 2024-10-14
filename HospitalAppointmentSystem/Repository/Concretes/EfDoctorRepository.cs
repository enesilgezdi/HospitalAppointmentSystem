using HospitalAppointmentSystem.Context;
using HospitalAppointmentSystem.Models;
using HospitalAppointmentSystem.Repository.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace HospitalAppointmentSystem.Repository.Concretes;

public class EfDoctorRepository : IDoctorRepository
{
    private MsSqlContext _context;

    public EfDoctorRepository(MsSqlContext context )
    {
        _context = context;
    }
    public Doctor Add(Doctor doctor)
    {
        _context.Doctors.Add( doctor );
        _context.SaveChanges();
        return doctor;
        
    }

    public Doctor Delete(int id)
    {
        Doctor doctor = GetById(id);
        _context.Doctors.Remove( doctor );
        _context.SaveChanges();
        return doctor;
    }

    public List<Doctor> GetAll()
    {
        return _context.Doctors.
            Include(x=>x.Patiens)
            .ToList();
    }


    public Doctor? GetById(int id)
    {
        Doctor? doctor = _context.Doctors.Find(id);
        return doctor;
    }

    public Doctor Uptdate(Doctor doctor)
    {
        _context.Doctors.Update(doctor );
        _context.SaveChanges();

        return doctor;
    }
}
