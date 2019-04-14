using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Models
{
    public class BookRepository
    {
        public static List<Book> books = new List<Book>();
        public static IEnumerable<Book> Books
        {
            get
            {
                return books;
            }
        }
        public static void AddResponse(Book book)
        {
             
            books.Add(book);
        }
    }
}
