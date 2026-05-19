using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class PredictionEntryEntity
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();

    [Required] 
    public string PredictionId { get; set; } = null!;
    public PredictionTableEntity Prediction { get; set; } = null!;
    
    public string Name { get; set; }
    
    public int Position { get; set; }
}