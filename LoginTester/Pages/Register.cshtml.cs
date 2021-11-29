using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace LoginTester.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public User user { get; set; }

        public UserDAL userDAL = new UserDAL();

        public void OnGet()
        {

        }

        public IActionResult OnPostCancel()
        {
            user = null;
            return RedirectToPage("/Login");
        }

        public IActionResult OnPostConfirm()
        {
            var response = userDAL.InsertUser(user);
            var successInsert = response.Success;

            TempData["AlertMessage"] = GlobalHelper.BusinessAlert(response.Message, successInsert ? WarningType.Success : WarningType.Danger);
            TempData["AlertType"] = successInsert ? WarningType.Success : WarningType.Danger; //change!!!!!!!!!!!!!!!!

            if (successInsert)
                return RedirectToPage("/Login");
            else
                return RedirectToPage("/Register");

        }
    }
}
