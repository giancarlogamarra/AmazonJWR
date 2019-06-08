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
    public class BookController : Controller
    {
        private IBookRepository repository;
        public BookController(IBookRepository repo)
        {
            repository = repo;
        }

        public ViewResult List()
        {
           return View(repository.Books);
        }
    }
}
