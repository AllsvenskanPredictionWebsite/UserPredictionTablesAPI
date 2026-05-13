using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<PredictionTableEntity> PredictionTables { get; set; }
    
    public DbSet<PredictionEntryEntity> PredictionEntries { get; set; }
}