using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class PredictionTableEntity
{
    [Key]
    public string PredictionId { get; set; } = Guid.NewGuid().ToString();
    
    public string UserId { get; set; }
    
    public ICollection<PredictionEntryEntity> Entries { get; set; } = new List<PredictionEntryEntity>();
}