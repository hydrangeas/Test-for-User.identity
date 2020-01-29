using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApplication2.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        public IndexModel()
        {
        }

        public string UserName = "";

        public void OnGet()
        {
            UserName = User.Identity.Name;
        }
    }
}
