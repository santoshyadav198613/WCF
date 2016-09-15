using Library.libraryService;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class LibraryController : Controller
    {
        // GET: Library
        [HttpGet]
        public JsonResult Index()
        {
            List<Book> book = new List<Book>();
            using (LibraryManagerClient client = new LibraryManagerClient())
            {
                book = client.RetriveBooks();
            }
            return Json(book, JsonRequestBehavior.AllowGet);
        }

    }
}