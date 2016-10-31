using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace testWCF
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        private List<Book> _book = new List<Book>()
        {
            new Book { Author="test",ID=1,Name="Test1" },
            new Book { Author="test1",ID=1,Name="Test2" }
        };

        public List<Book> GetBooks(Book book)
        {
            _book.Add(book);
            return _book;
        }
    }
}
