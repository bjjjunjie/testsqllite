using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using testsqlite.DataAccess;
using testsqlite.Models;

namespace testsqlite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private MyDbContext _myDbContext;

        public IndexModel(ILogger<IndexModel> logger,MyDbContext myDbContext)
        {
            _logger = logger;
            _myDbContext = myDbContext;
        }

        public void OnGet()
        {
            User user = new User() {Name="222"};
            _myDbContext.User.Add(user);
            _myDbContext.SaveChanges();
        }
    }
}