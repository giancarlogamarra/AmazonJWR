using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Amazon.Models;
using Amazon.Models.Extensions;

namespace Amazon.Controllers
{
    public class HomeController : Controller
    {
        public IRepository repository = BookRepository.SharedRepository;
        [HttpGet]
        public IActionResult Index() {
            return View("Index", repository.Books.FilterByNroPagesGreaterThan(300).ToList());
        }
        [HttpGet]
        public ViewResult RegBookForm() {
            return View();
        }
        [HttpPost]
        public ViewResult RegBookForm(Book book)
        {
            if (ModelState.IsValid)
            {
                repository.AddBook(book);
                return View("Thanks", book);
            }
            else {
                return View();
            }
        }

        [HttpGet]
        public ViewResult ListResponses()
        {
            IEnumerable<Book> books = repository.Books.FilterByNroPagesGreaterThan(0);
            ViewBag.TotalPrice = books.TotalPriceExtension();
          return View(books);
        }





        [HttpGet]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
