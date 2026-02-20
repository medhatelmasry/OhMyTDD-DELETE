using System.ComponentModel;

namespace FizzBuzzLibrary;

public class FizzBuzz
{
    /*
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
    }*/
    public string GetResult(object o)
    {
        switch (o)
        {
            case string s when s.Contains("Fizz") || s.Contains("Buzz"):
                return s;
            case int n when n % 5 == 0 && n % 3 == 0:
                return "FizzBuzz";
            case int n when n % 5 == 0:
                return "Buzz";
            case int n when n % 3 == 0:
                return "Fizz";
            case int n:
                return n.ToString();
            default:
                throw new ArgumentException("Invalid input type");
        }
    }


}
