using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testClient.testService;

namespace testClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Service1Client client = new Service1Client())
            {
                Book b = new Book() { Author = "test3", ID = 3, Name = "test4" };
                List<Book> book = client.GetBooks(b);
                Console.WriteLine("Book Count" + book.Count);
                Book b1 = new Book() { Author = "test4", ID = 3, Name = "test5" };
                List<Book> book1 = client.GetBooks(b1);
                Console.WriteLine("Book Count" + book1.Count);
                Console.ReadLine();
            }
        }
    }
}
