using ASPA_007_1;
using DAL_Celebrity_MSSQL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace ASPA007_1.Pages
{
    public class NewCelebrityModel : PageModel
    {

        public string pathToZero = "api/Celebrities/photo/ALMAZ.jpg";

        public IRepository repo;
        public string PhotosRequestPath { get; set; }
        public string PhotosFolder { get; set; }
        public Celebrity? Celebrity { get; set; }
        public NewCelebrityModel(IRepository repo, IOptions<CelebritiesConfig> config)
        {
            this.repo = repo;
            this.PhotosRequestPath = config.Value.PhotosRequestPath;
            this.PhotosFolder = config.Value.PhotosFolder;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost(
                [FromForm] string? fullName,
                [FromForm] string? nationality,
                IFormFile upload,
                string? press,
                string? filename)
        {
            IActionResult rc = RedirectToPage("Celebrities");

            if (string.IsNullOrEmpty(press))
            {
                string fn = Path.GetFileName(Path.GetTempFileName());
                string fp = Path.Combine(this.PhotosFolder, fn);
                FileStream file = new FileStream(fp, FileMode.CreateNew);
                upload.CopyTo(file);
                file.Close();
                rc = RedirectToPage("NewCelebrity", "Confirm", new { filename = fn, fullname = fullName, nationality = nationality });
            }
            else if (press.Equals("Confirm"))
            {
                string newfilename = $"{fullName.Replace(" ", "_")}.{filename}.jpg";
                Directory.Move(Path.Combine(this.PhotosFolder, filename), Path.Combine(this.PhotosFolder, newfilename));
                this.repo.AddCelebrity(new Celebrity { FullName = fullName, Nationality = nationality, ReqPhotoPath = newfilename });
                rc = RedirectToPage("Celebrities");
            }
            else
            {
                rc = RedirectToPage("NewCelebrity");
            }
            return rc;
        }

        public IActionResult OnGetConfirm(string fullname, string nationality, string filename)
        {
            ViewData["Confirm"] = true;
            this.Celebrity = new Celebrity() { FullName = fullname, Nationality = nationality, ReqPhotoPath = filename };
            Debug.WriteLine(filename);
            Debug.WriteLine(this.PhotosFolder);
            return Page();
        }
    }
}
