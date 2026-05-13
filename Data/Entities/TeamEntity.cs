using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class TeamEntity
{
    [Key]
    public string TeamId { get; set; } = Guid.NewGuid().ToString();
    
    public string ControllTeamId { get; set; }
    
    public string Name { get; set; }
    
    public int Position { get; set; }
}