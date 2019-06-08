using Amazon.Models;
using System.Collections.Generic;
using System.Collections; 

namespace Amazon.UnitTests
{
    public class BookTestData : IEnumerable<object[]>
    {
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { GetNroPagesUnder300() };
            yield return new object[] { GetNroPagesOver300 };
        }
        //METODO
        private IEnumerable<Book> GetNroPagesUnder300()
        {
            List<Book> ListBooks = new List<Book>();
            int[] nroPages = new int[] { 250, 180, 250, 290 };
            for (int i = 0; i < nroPages.Length; i++)
            {
                ListBooks.Add(new Book
                {
                    Title = $"P{i + 1}",
                    NroPages = nroPages[i]
                });
            }
            return ListBooks;
        }
        //PROPIEDAD
        private IEnumerable<Book> GetNroPagesOver300 => new List<Book> {
            new Book { Title = "P1", NroPages = 320 },
            new Book { Title = "P2", NroPages = 310},
            new Book { Title = "P3", NroPages = 400},
            new Book { Title = "P4", NroPages = 500}};
        }
}
