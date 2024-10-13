using HospitalAppointmentSystem.Models.Enums;

namespace HospitalAppointmentSystem.Models;

public sealed class Doctor:Entity
{
    public string Name { get; set; }

    public Branch Branch { get; set; }

    public List<Appointment> Appointments { get; set; }

}
