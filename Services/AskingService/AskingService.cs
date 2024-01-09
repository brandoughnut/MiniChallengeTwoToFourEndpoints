namespace MiniChallengeTwoToFourEndpoints.Services.AddService.AskingService;
public class AskingService : IAskingService
{
    public string AskQuestions(string name, string time)
    {
        return $"Good job {name}, for waking up at {time}.";
    }
}