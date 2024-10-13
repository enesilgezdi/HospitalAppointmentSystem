namespace HospitalAppointmentSystem.Models.Dtos.Appointments.Request;

public class AppointmentDto
{
    public string PatientName { get; set; }
    public DateTime AppointmentDate { get; set; }
    public int DoctorId { get; set; }
}
