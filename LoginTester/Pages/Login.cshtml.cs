using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace LoginTester.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public User user { get; set; }

        public UserDAL userDAL = new UserDAL();

        public void OnGet()
        {
        }

        public IActionResult OnPostLogin()
        {
            var response = userDAL.LoginUser(user);

            var successLogin = response.Success;

            TempData["AlertMessage"] = GlobalHelper.BusinessAlert(response.Message, successLogin ? WarningType.Success : WarningType.Danger);
            TempData["AlertType"] = successLogin ? WarningType.Success : WarningType.Danger; //change!!!!!!!!!!!!!!!!

            if (successLogin)
                return RedirectToPage("/MainPage");
            else
                return RedirectToPage("/Login");
        }

        public IActionResult OnPostRegister()
        {
            return RedirectToPage("/Register");
        }
    }
}
