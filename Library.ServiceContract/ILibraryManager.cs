using Library.DataContract;
using System.Collections.Generic;
using System.ServiceModel;

namespace Library.ServiceContract
{
    [ServiceContract]
    public interface ILibraryManager
    {
        [OperationContract]
        List<Book> AddNewBook(Book book);
        [OperationContract]
        List<Book> RetriveBooks();
    }
}
