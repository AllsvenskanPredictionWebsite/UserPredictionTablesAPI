using Business.Models;
using Data;
using Data.Entities;

namespace Business.Services;

public class PredictionTableService(IPredictionTableRepository predictionTableRepository) : IPredictionTableService
{
    private readonly IPredictionTableRepository _predictionTableRepository = predictionTableRepository;

    public async Task<bool> CreatePredictionAsync(AddUserPredictionData data)
    {
        if(data == null)
            return false;
        
        var entity = new PredictionTableEntity
        {
            UserId = data.UserId,
            Teams = data.Teams
        };
        
        var result = await _predictionTableRepository.AddAsync(entity);
        return result;
    }

    public async Task<PredictionTable?> GetPredictionByUserIdAsync(string userId)
    {
        var entity = await _predictionTableRepository.GetAsync(x => x.UserId == userId);

        return entity == null
            ? null
            : new PredictionTable
            {
                PredictionId =  entity.PredictionId,
                UserId = entity.UserId,
                Teams = entity.Teams
            };
    }

    public async Task<bool> UpdatePredictionAsync(UpdateUserPredictionData data)
    {
        if (data == null)
            return false;

        var entity = new PredictionTableEntity
        {
            PredictionId = data.PredictionId,
            UserId = data.UserId,
            Teams = data.Teams
        };
        
        var result = await _predictionTableRepository.UpdateAsync(entity);
        return result;
    }
}