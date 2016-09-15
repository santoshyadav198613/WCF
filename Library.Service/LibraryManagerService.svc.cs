using Library.DataContract;
using Library.ServiceContract;
using System;
using System.Collections.Generic;

namespace Library.Service
{
    public class LibraryManagerService : ILibraryManager
    {
        private List<Book> _books = new List<Book>()
        {
            new Book { BookId=1,Author="Santosh",Name="Test Book",Publisher="Test Publisher",Subject="Test"  },
                new Book {BookId=1,Author="Santosh",Name="Test Book",Publisher="Test Publisher",Subject="Test" }
        };

        public List<Book> AddNewBook(Book book)
        {
            _books.Add(book);
            return _books;
        }

        public List<Book> RetriveBooks()
        {
            return _books;
        }
    }
}
