using Business.Models;

namespace Business.Services;

public interface IPredictionTableService
{
    Task<bool> CreatePredictionAsync(AddUserPredictionData data);
    Task<PredictionTable?> GetPredictionByUserIdAsync(string userId);
    Task<bool> UpdatePredictionAsync(UpdateUserPredictionData data);
}