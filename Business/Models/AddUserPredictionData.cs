using Data.Entities;

namespace Business.Models;

public class AddUserPredictionData
{
    public string UserId { get; set; }
    
    public ICollection<TeamEntity> Teams { get; set; }
}