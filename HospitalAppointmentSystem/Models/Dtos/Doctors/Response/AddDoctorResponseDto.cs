using HospitalAppointmentSystem.Models.Enums;

namespace HospitalAppointmentSystem.Models.Dtos.Doctors.Response;

public class AddDoctorResponseDto
{
    public string Name { get; set; }

    public string Branch {  get; set; }

    public List<string> PatientsNames { get; set; }

    public static implicit operator AddDoctorResponseDto(Doctor doctor)
    {
        return new AddDoctorResponseDto
        {
            Branch = doctor.Branch.ToString(),
            PatientsNames = doctor.Patiens.Select(x => x.PatientName).ToList(),
            Name = doctor.Name
        };
    }
}
