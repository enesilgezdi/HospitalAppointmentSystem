using HospitalAppointmentSystem.Models;

namespace HospitalAppointmentSystem.Repository.Abstracts;

public interface IEntityRepository<TEntity ,TId> where TEntity : Entity<TId>, new()
{
    TEntity? GetById(TId id);
    List<TEntity> GetAll();

    TEntity Add(TEntity doctor);

    TEntity Uptdate(TEntity doctor);

    TEntity Delete(TId id);


}
