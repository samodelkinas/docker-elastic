using Microsoft.AspNetCore.Mvc;

namespace apm_demo.Controllers;

[ApiController]
[Route("[controller]")]
public class ConversionController : ControllerBase
{
    private readonly ILogger<ConversionController> _logger;
    public ConversionController(ILogger<ConversionController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetConvertedUnits")]
    public int Get([FromQuery(Name = "SourceValue")] string SourceValue)
    {
        string[] SourceValueSplitted = SourceValue.Split("_");
        int ResultValue = 0;
        ResultValue = SourceValueSplitted[1] == "Pa" ? ResultValue = int.Parse(SourceValueSplitted[0])/1000 : 0;
        return ResultValue;
    }
}
