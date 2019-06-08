using Amazon.Controllers;
using Amazon.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Amazon.UnitTests
{
    public class IndexControllerTests
    {
       /* class ModelCompleteFakeRepository : IRepository
        {
            public IEnumerable<Book> Books{ set; get; }
            public void AddBook(Book p)
            { 
                //no requerido para el test 
            }
        }*/

       /* [Theory]
        [ClassData(typeof(BookTestData))]
        public void IndexActionModelIsComplete(IQueryable<Book> books)
        {
            // Arrange 
            var mock = new Mock<IBookRepository>();
            mock.SetupGet(m => m.Books).Returns(books);
            var controller = new BookController
            {
                repository = mock.Object
            };

            // Act 
            var model = (controller.Index() as ViewResult)?.ViewData.Model as IEnumerable<Book>;
            // Assert 
            Assert.Equal(controller.repository.Books, model,
                Comparer.Get<Book>(
                    (p1, p2) => p1.Title == p2.Title
                    && p1.NroPages == p2.NroPages));

        }*/

        /*class ModelCompleteFakeRepositoryPagesGreaterThan300 : IRepository
        {
            public IEnumerable<Book> Books => new List<Book>
            {
                new Book() { Title = "Book1", Price = 200, NroPages = 320 },
                new Book() { Title = "Book2", Price = 280, NroPages = 310 },
                new Book() { Title = "Book3", Price = 150, NroPages = 500 },
                new Book() { Title = "Book4", Price = 300, NroPages = 800 }
            };
            public void AddBook(Book p) { }
        }*/

        /*[Fact]
        public void IndexActionModelIsCompletePagesGreaterThan300()
        { 
            // Arrange 
            var controller = new HomeController();
            controller.repository = new ModelCompleteFakeRepositoryPagesGreaterThan300();
            // Act 
            var model = (controller.Index() as ViewResult)?.ViewData.Model as IEnumerable<Book>;
            // Assert 
            Assert.Equal(
                (controller.repository.Books as List<Book>).Count,
                (model as List<Book>).Count);
        }*/

     }
}
