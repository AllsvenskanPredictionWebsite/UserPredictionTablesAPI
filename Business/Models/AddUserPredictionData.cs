using Data.Entities;

namespace Business.Models;

public class AddUserPredictionData
{
    public string UserId { get; set; }
    
    public ICollection<PredictionEntryEntity> Entries { get; set; }
}