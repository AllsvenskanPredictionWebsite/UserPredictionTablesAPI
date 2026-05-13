using Data.Contexts;
using Data.Entities;

namespace Data;

public class PredictionTableRepository(DataContext context) : BaseRepository<PredictionTableEntity>(context), IPredictionTableRepository;