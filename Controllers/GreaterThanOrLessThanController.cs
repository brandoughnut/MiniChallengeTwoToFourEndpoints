using Microsoft.AspNetCore.Mvc;
using MiniChallengeTwoToFourEndpoints.Services.AddService.AskingService.GreaterService;

namespace MiniChallengeTwoToFourEndpoints.Controllers;
[ApiController]
[Route("[controller]")]
public class GreaterThanOrLessThanController : ControllerBase
{
    private readonly IGreaterService _greaterService;

    public GreaterThanOrLessThanController(IGreaterService greaterService)
    {
        _greaterService = greaterService;
    }
    [HttpGet]
    [Route("GreaterLess/{numOne}/{numTwo}")]
    public string GreaterLess(string numOne, string numTwo)
    {
        return _greaterService.GreaterLess(numOne, numTwo);
    }
}