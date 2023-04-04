using backend.Interfaces;

namespace backend.Services;

public class AnalisisBanner: IAnalisisBanner
{
    private readonly ApplicationContext _db;
    
    public AnalisisBanner(ApplicationContext db)
    {
        _db = db;
    }
    public async Task ReceivingInformation(Analys analys)
    {
        try
        {
            await _db.Analyses.AddAsync(analys);
            await _db.SaveChangesAsync();
        }
        catch
        {
            throw;
        }
    }

   
}