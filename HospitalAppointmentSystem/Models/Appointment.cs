namespace HospitalAppointmentSystem.Models;

public sealed class Appointment : Entity
{
   
    public Guid PatientId { get; set; }

    public DateTime AppointmentDate { get; set; }

    public int DoctorId { get; set; }
    public Doctor Doctor { get; set; }
}
