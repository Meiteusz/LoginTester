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
            return Redirect("/Login");
        }

        public IActionResult OnPostConfirm()
        {
            var response = userDAL.InsertUser(user);

            if (response.Success)
                return RedirectToPage("/Login");
            else
                return RedirectToPage("/Register");
        }
    }
}
