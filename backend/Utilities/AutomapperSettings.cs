namespace backend.Utilities;

public class AutomapperSettings: Profile
{
    public AutomapperSettings()
    {
        CreateMap<GetAnalisisRequest, Analys>();
    }
}