using Data.Entities;

namespace Business.Models;

public class PredictionTable
{
    public string PredictionId { get; set; }
    
    public string UserId { get; set; }
    
    public ICollection<PredictionEntryEntity> Entries { get; set; }
}