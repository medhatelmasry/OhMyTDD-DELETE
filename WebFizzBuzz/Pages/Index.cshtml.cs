using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebFizzBuzz.Pages;
using FizzBuzzLibrary;
public class IndexModel : PageModel
{
    public void OnGet()
    {

    }

    public void OnPost(int numberInput)
    {
        // Process the input as needed
        FizzBuzz fizzBuzz = new();
        var result = fizzBuzz.GetResult(numberInput);

        ViewData["Result"] = result;
    }
}
