using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Models
{
    public interface IRepository
    {
        IEnumerable<Book> Books { get; }
        void AddBook(Book p);
    }
}
