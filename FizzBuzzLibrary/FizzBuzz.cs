using System.ComponentModel;

namespace FizzBuzzLibrary;

public class FizzBuzz
{
    public string GetResult(int number)
    {

        if (number < 0) {
            throw new Exception("Number cannot be negative");
        }

        if (number > 10000) {
            throw new Exception("Number cannot exceed 10000");
        }

        string result = string.Empty;

        if (number % 3 == 0 && number % 5 == 0) {
            result += "FizzBuzz";
        } else if (number % 3 == 0) {
            result += "Fizz";
        } else if (number % 5 == 0) {
            result += "Buzz";
        } else {
            result += number.ToString();
        }

        return result;
    }

}
