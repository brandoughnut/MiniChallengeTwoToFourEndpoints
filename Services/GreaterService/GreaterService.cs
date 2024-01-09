namespace MiniChallengeTwoToFourEndpoints.Services.AddService.AskingService.GreaterService;
public class GreaterService : IGreaterService
{
    public string GreaterLess(double numOne, double numTwo)
    {
        if (numOne > numTwo)
        {
            return $"{numOne} is greater than {numTwo}.\n{numTwo} is less than {numOne}.";
        }
        else if (numTwo > numOne)
        {
            return $"{numOne} is less than {numTwo}.\n{numTwo} is greater than {numOne}.";
        }
        else
        {
            return $"{numOne} is equal to {numTwo}.\n{numTwo} is equal to {numOne}.";
        }
    }
}