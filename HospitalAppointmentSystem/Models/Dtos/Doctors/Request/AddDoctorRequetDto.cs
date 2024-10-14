using HospitalAppointmentSystem.Models.Enums;

namespace HospitalAppointmentSystem.Models.Dtos.Doctors.Request;

public class AddDoctorRequetDto
{
    public string Name { get; set; }
    public Branch Branch { get; set; }
}
