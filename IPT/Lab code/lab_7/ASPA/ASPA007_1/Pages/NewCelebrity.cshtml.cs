using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPA007_1.Pages
{
    public class NewCelebrityModel : PageModel
    {

        public string pathToZero = "api/Celebrities/photo/ALMAZ.jpg";

        public void OnGet()
        {
        }
    }
}
