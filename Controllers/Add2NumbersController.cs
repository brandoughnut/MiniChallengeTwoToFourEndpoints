using MiniChallengeTwoToFourEndpoints.Services.AddService;
using Microsoft.AspNetCore.Mvc;

namespace MiniChallengeTwoToFourEndpoints.Controllers;
[ApiController]
[Route("[controller]")]
public class Add2NumbersController : ControllerBase
{
    private readonly IAddService _addService;

    public Add2NumbersController(IAddService addService)
    {
        _addService = addService;
    }
    [HttpGet]
    [Route("AddNumbers/{numOne}/{numTwo}")]
    public double AddNumbers(double numOne, double numTwo)
    {
        return _addService.AddNumbers(numOne, numTwo);
    }
}