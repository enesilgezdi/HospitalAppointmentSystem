namespace HospitalAppointmentSystem.ReturnModels;

public class ReturnModels<T>
{
    public T Data { get; set; }

    public bool success { get; set; }

    public string Message { get; set; }
}
