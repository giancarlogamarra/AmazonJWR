﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.Infrastructure;
using Amazon.Models;
using Amazon.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Amazon.Controllers
{
    public class CartController : Controller
    {
        private IBookRepository repository;
        private Cart cart;
        public CartController(IBookRepository repo, Cart cartService)
        {
            repository = repo;
            this.cart = cartService;
        }
        public ViewResult Index(string returnUrl) {
            return View(new CartIndexViewModel {
                Cart = cart,
                ReturnUrl = returnUrl });
        }

        public RedirectToActionResult AddToCart(Guid bookId, string returnUrl)
        {
            Book book = repository.Books
            .FirstOrDefault(p => p.BookId == bookId);
            if (book != null)
            {
                cart.AddItem(book, 1);
            }
            return RedirectToAction("Index", new
            {
                returnUrl
            });
        }
        public RedirectToActionResult RemoveFromCart(Guid bookId, string returnUrl)
        {
            Book book = repository.Books
            .FirstOrDefault(p => p.BookId == bookId);
            if (book != null)
            {
                cart.RemoveLine(book);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
    
    }
}
