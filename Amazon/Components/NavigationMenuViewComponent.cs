using Amazon.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBookRepository repository;
        public NavigationMenuViewComponent(IBookRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            return View(repository.Books
            .Select(x => x.Category)
            .Distinct()
            .OrderBy(x => x));
        }
    }
}
