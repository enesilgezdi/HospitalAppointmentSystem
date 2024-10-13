using HospitalAppointmentSystem.Models;

namespace HospitalAppointmentSystem.Repository.Abstracts;

public interface IEntityRepository<TEntity> where TEntity : Entity, new()
{
    TEntity? GetById(int id);
    List<TEntity> GetAll();

    TEntity Add(TEntity doctor);

    TEntity Uptdate(TEntity doctor);

    TEntity Delete(int id);


}
