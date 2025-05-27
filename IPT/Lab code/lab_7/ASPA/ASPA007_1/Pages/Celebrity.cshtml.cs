using ASPA_007_1;
using DAL_Celebrity_MSSQL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace ASPA007_1.Pages
{
    public class CelebrityModel : PageModel
    {


        public IRepository repo { get; set; }
        public string PhotosRequestPath { get; private set; }
        public Celebrity? celebrity { get; private set; }

        public List<LifeEvent> LifeEvents { get; set; } = new List<LifeEvent>();
        [FromRoute]
        public int Id { get; set; } = -1;

        [FromQuery(Name = "id")]
        public int? queryId { get; set; } = null;

        [FromHeader(Name = "Accept")]
        public string? AcceptHeadet { get; set; } = null;

        public CelebrityModel(IRepository repository, IOptions<CelebritiesConfig> config)
        {
            this.repo = repository;
            this.PhotosRequestPath = config.Value.PhotosRequestPath;
          
            Debug.WriteLine(LifeEvents.Count);
        }
        public IActionResult OnGet()
        {
            (string?, int) t = preferredAcceptMIMO(this.AcceptHeadet, new string[] { "html", "json" });
            return ((this.celebrity = repo.GetCelebrityById(this.Id)) is null) ?
                NotFound() : (t.Item1 == "json") ?
                this.RedirectToRoute("GetCelebrityById", new { Id = this.Id }) : Page();
        }


        private (string?, int) preferredAcceptMIMO(string? accept, string[]parms)
        {
            (string?, int) rc = (null, -1);
            if(accept != null)
            {
                int k = -1;
                int mink = accept.Length + 1;
                int mini = -1;
                for(int i = 0; i < parms.Length; i++)
                {
                    if ((k = accept.IndexOf(parms[i], StringComparison.OrdinalIgnoreCase)) >= 0)
                    {
                        if (k < mink)
                        {
                            mink = k;
                            mini = i;
                        }
                    }
                }
                rc = ((mini > 0) ? parms[mini] : null, mini);
            }
            return rc;
        }
    }
}
