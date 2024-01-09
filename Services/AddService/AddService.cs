namespace MiniChallengeTwoToFourEndpoints.Services.AddService;
public class AddService : IAddService
{
    public double AddNumbers(double numOne, double numTwo)
    {
        return numOne + numTwo;
    }
}