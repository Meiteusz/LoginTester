using Microsoft.AspNetCore.Mvc;

namespace LoginTester
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OnPostCancel()
        {
            return Redirect("/Login");
        }

        public void OnPostClearAll()
        {

        }

        public void teste(string txtFirstName)
        {

        }

        public IActionResult OnPostConfirm()
        {
            return Redirect("/Login");
        }
    }
}
