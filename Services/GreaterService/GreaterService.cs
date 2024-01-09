namespace MiniChallengeTwoToFourEndpoints.Services.AddService.AskingService.GreaterService;
public class GreaterService : IGreaterService
{
    public string GreaterLess(string numOne, string numTwo)
    {
        bool isTrue1 = Double.TryParse(numOne, out double num1);
        bool isTrue2 = Double.TryParse(numTwo, out double num2);

        if (isTrue1 == false || isTrue2 == false)
        {
            return "User input was not a valid number. Try again!";
        }
        else
        {
            if (num1 > num2)
            {
                return $"{num1} is greater than {num2}.\n{num2} is less than {num1}.";
            }
            else if (num2 > num1)
            {
                return $"{num1} is less than {num2}.\n{num2} is greater than {num1}.";
            }
            else
            {
                return $"{num1} is equal to {num2}.\n{num2} is equal to {num1}.";
            }
        }

    }
}