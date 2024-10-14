using HospitalAppointmentSystem.Models;
using HospitalAppointmentSystem.Models.Dtos.Doctors.Request;
using HospitalAppointmentSystem.ReturnModels;

namespace HospitalAppointmentSystem.Services.Abstracts;

public interface IDoctorService
{
    ReturnModels<Doctor> Add(AddDoctorRequetDto doctor);


    Doctor Delete(int id);

    List<Doctor> GetAll();




    Doctor? GetById(int id);


    Doctor Uptdate(AddDoctorRequetDto doctor);
    

}
