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
    public string GreaterLess(double numOne, double numTwo)
    {
        if (numOne > numTwo)
        {
            return _greaterService.GreaterLess(numOne, numTwo);
        }
        else if (numTwo > numOne)
        {
            return _greaterService.GreaterLess(numOne, numTwo);
        }
        else
        {
            return _greaterService.GreaterLess(numOne, numTwo);
        }

    }
}