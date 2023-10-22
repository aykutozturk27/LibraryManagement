using LibraryManagement.Business.Abstract;
using LibraryManagement.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace LibraryManagement.MvcWebUI.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BorrowedBook()
        {
            return View();
        }

        public IActionResult BookOutsideLibrary()
        {
            return View();
        }

        [HttpPost]
        public string GetBookList()
        {
            var bookList = _bookService.GetBookWithPersonalList();
            return JsonConvert.SerializeObject(bookList);
        }

        [HttpPost]
        public string GetBorrowedBookList()
        {
            var list = _bookService.GetBorrowedBookList();
            return JsonConvert.SerializeObject(list);
        }

        [HttpPost]
        public string GetBookOutsideLibraryGroupedISBN()
        {
            var bookOutsideLibrary = _bookService.GetBookOutsideLibraryGroupedISBN();
            return JsonConvert.SerializeObject(bookOutsideLibrary);
        }

        public IActionResult Add()
        {
            var list = _bookService.GetBookWithPersonalList();
            var personalList = list.Select(x => x.Personal).ToList();
            ViewBag.PersonalList = new SelectList(personalList, "Id", "FullName");
            return View();
        }

        [HttpPost]
        public IActionResult Add(Book book)
        {
            if (ModelState.IsValid)
            {
                var addedBook = _bookService.Add(book);
                if (addedBook != null)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(book);
                }
            }
            return View(book);
        }

        [HttpPost]
        public JsonResult SetBookBorrowed(string identityNumber)
        {
            var borrowedBook = _bookService.SetBookBorrowedByIdentity(identityNumber);
            return Json(borrowedBook);
        }
    }
}
