using Amazon.Controllers;
using Amazon.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Amazon.UnitTests
{
    public class IndexControllerTests
    {
        [Fact]
        public void IndexActionModelIsComplete()
        {
            // Arrange
            var controller = new HomeController();
            // Act
            var model = (controller.Index() as ViewResult)?.ViewData.Model
            as IEnumerable<Book>;
            // Assert
            Assert.Equal(BookRepository.books, model);
        }
    }
}
