using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.Models;
using Microsoft.AspNetCore.Mvc;

namespace Amazon.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult CheckOut()
        {
            return View(new Order());
        }
    }
}