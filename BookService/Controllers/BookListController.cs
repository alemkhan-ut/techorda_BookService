using BookService.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookService.Controllers
{
    public class BookListController : Controller
    {
        public IActionResult Index()
        {
            BookModel[] books = new BookModel[]
            {
               
            };

            return View(books);
        }

        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
