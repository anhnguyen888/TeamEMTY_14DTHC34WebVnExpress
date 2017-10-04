using _14DTHC34Web.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace _14DTHC34Web.Controllers
{
    public class BooksController : Controller
    {
        private List<Book> listBooks;

        //Constructor
        public BooksController()
        {
            listBooks = new List<Book>();
            //Add some books
            listBooks.Add(new Book()
            {
                BookId = 1,
                Title = "Dac Nhan Tam",
                Author = "DC",
                Year = 2017,
                Cover = "Content/images/book-1.png"
            });
            listBooks.Add(new Book()
            {
                BookId = 2,
                Title = "Pro ASP .NET MVC 5",
                Author = "Freeman, Adam",
                Year = 2013,
                Cover = "Content/images/book-2.png"
            });
            listBooks.Add(new Book()
            {
                BookId = 3,
                Title = "Clean Code",
                Author = "...",
                Year = 2010,
                Cover = "Content/images/book-3.png"
            });
        }

        // GET: Books
        public ActionResult Index()
        {
            return View();
        }

        public string HelloController(string info)
        {
            return "My first Controller! " + info;
        }

        public ActionResult GetListBooks()
        {
            return View("ListBooks", listBooks);
        }

        public ActionResult Edit(int id)
        {
            Book book = listBooks.Find(s => s.BookId == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        [HttpPost]
        public ActionResult Edit(Book bookSender)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("","Server check invalid!");
                return View();
            }
            Book book = listBooks.Find(s => s.BookId == bookSender.BookId);
            if (book == null)
                return HttpNotFound();
            //update info
            book.Title = bookSender.Title;
            book.Author = bookSender.Author;
            book.Year = bookSender.Year;

            //return view list books
            return View("ListBooks", listBooks);
        }
    }
}