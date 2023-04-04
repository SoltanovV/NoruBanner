using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BannerController: ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IAnalisisBanner _analisis;
    private readonly ILogger<BannerController> _logger;

    public BannerController(IMapper mapper, IAnalisisBanner analisis, ILogger<BannerController> logger)
    {
        _mapper = mapper;
        _analisis = analisis;
        _logger = logger;
    }

    [HttpPost]
    [Route("analisis")]
    public async Task<IActionResult> GetAnalisis(GetAnalisisRequest request)
    {
        try
        {
            _logger.LogInformation("Запрос GetAnalisisRequest получен");
            
            request.UserIp = HttpContext.Connection.RemoteIpAddress.ToString();
            
            var map = _mapper.Map<Analys>(request);
            await _analisis.ReceivingInformation(map);
            
            _logger.LogInformation("Запрос GetAnalisisRequest обработан");
            
            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            return BadRequest(ex.Message);
        }
    }
}