namespace MiniChallengeTwoToFourEndpoints.Services.AddService;
public class AddService : IAddService
{
    public string AddNumbers(string numOne, string numTwo)
    {
        bool isTrue1 = Double.TryParse(numOne, out double num1);
        bool isTrue2 = Double.TryParse(numTwo, out double num2);

        if(isTrue1 == false || isTrue2 == false){
            return "User input was not a valid number. Try again!";
        }else{
            double sum = num1+num2;
            return $"{num1} + {num2} is equal to {sum}."; 
        }        
    }
}