using System.Linq.Expressions;
using Data.Entities;

namespace Data;

public interface IPredictionTableRepository
{
    Task<bool> AddAsync(PredictionTableEntity entity);
    Task<IEnumerable<PredictionTableEntity>> GetAllAsync();
    Task<PredictionTableEntity?> GetAsync(Expression<Func<PredictionTableEntity, bool>> expression);
    Task<bool> UpdateAsync(PredictionTableEntity entity);
    Task<bool> DeleteAsync(Expression<Func<PredictionTableEntity, bool>> expression);
}