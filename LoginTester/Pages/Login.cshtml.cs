using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoginTester.Pages
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPostLogin()
        {
            return Redirect("");
        }

        public IActionResult OnPostRegister()
        {
            return RedirectToPage("/Register");
        }
    }
}
