using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Amazon.Models;
using Amazon.Models.Extensions;
using Amazon.Models.ViewModels;

namespace Amazon.Controllers
{
    public class BookController : Controller
    {
        private IBookRepository repository;
        public int PageSize = 4;
        public BookController(IBookRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(int bookPage = 1)
        {
            var bookListViewModel = new BooksListViewModel
            {
                Books = repository.Books
                .OrderBy(p => p.Price)
                .Skip((bookPage - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo {
                    CurrentPage = bookPage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Books.Count()
                }
            };
            return View(bookListViewModel);
        }
    }
}
