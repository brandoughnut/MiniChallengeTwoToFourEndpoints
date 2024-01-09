using Microsoft.AspNetCore.Mvc;
using MiniChallengeTwoToFourEndpoints.Services.AddService.AskingService;

namespace MiniChallengeTwoToFourEndpoints.Controllers;
[ApiController]
[Route("[controller]")]
public class AskingQuestionsController : ControllerBase
{
    private readonly IAskingService _askingService;

    public AskingQuestionsController(IAskingService askingService)
    {
        _askingService = askingService;
    }
    [HttpGet]
    [Route("AskQuestions/{name}/{time}")]
    public string AskQuestions(string name, string time)
    {
        return _askingService.AskQuestions(name, time);
    }
}
