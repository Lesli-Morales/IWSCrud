using IWSCrud.Data;
using Microsoft.AspNetCore.Mvc;

namespace IWSCrud.Controllers
{
    public class CatalogsTypesController : Controller
    {

        private readonly ApplicationDbContext _context;

        public CatalogsTypesController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
