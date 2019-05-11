using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Amazon.Models;
namespace Amazon.UnitTests
{
    public class BookTests
    {
        [Fact]
        public void CanChangeBookTitle()
        {
            //Arange
            var p = new Book() { Title = "Test", Price = 200 };
            //Act
            p.Title = "New Title";
            //Assert
            Assert.Equal("New Title", p.Title);
        }
        [Fact]
        public void CanChangeBookPrice()
        {
            //Arange
            var p = new Book() { Title = "Test", Price = 200 };
            //Act
            p.Price = 300;
            //Assert
            Assert.Equal(300, p.Price);
        }

    }
}
