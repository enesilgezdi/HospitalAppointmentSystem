using HospitalAppointmentSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalAppointmentSystem.Context;

public class MsSqlContext : DbContext
{
    public MsSqlContext(DbContextOptions opt): base(opt)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Docker kurulu olanlar 
        //optionsBuilder.UseSqlServer("Server= localhost,1433; Database = Identit_db; User=sa; Password=admin123456789; TrustServerCertificate=true");

        // Localdb
        optionsBuilder.UseSqlServer(@"Server= (localdb)\MSSQLLocalDB; Database=Hospital_db; Trusted_Connection = true");
    }

    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Appointment> Appointments { get; set; }

  
}
