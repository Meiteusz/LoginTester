using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace LoginTester.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public User user { get; set; }

        public string testName { get; set; } ="teste";

        public void OnGet()
        {
            
        }

        public IActionResult OnPostCancel()
        {
            return Redirect("/Login");
        }

        public void OnPostClearAll()
        {

        }

        public IActionResult OnPostConfirm()
        {
            if (ModelState.IsValid)
            {

            }

            return RedirectToPage("/Login");
        }
    }
}
