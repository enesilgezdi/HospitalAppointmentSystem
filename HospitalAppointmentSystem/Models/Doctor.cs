using HospitalAppointmentSystem.Models.Dtos.Doctors.Request;
using HospitalAppointmentSystem.Models.Enums;

namespace HospitalAppointmentSystem.Models;

public sealed class Doctor:Entity<int>
{
    public string Name { get; set; }

    public Branch Branch { get; set; }

    public List<Appointment> Patiens { get; set; }

    public Doctor()
    {
        Patiens = new List<Appointment>();
    }

    public static explicit operator Doctor(AddDoctorRequetDto dto)
    {
        return new Doctor
        {
            Name = dto.Name,
            Branch = dto.Branch,

        };
    }

}
