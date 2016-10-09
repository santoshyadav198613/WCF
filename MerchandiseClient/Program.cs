using MerchandiseClient.MerchandiseService;
using System;

namespace MerchandiseClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (MerchandiseServiceClient client = new MerchandiseServiceClient())
                {
                    long loginId = client.Login("test", "test");
                    if (loginId > 0)
                    {
                        Console.WriteLine("User loggedin");
                    }
                    bool resultCart = client.AddToCart(loginId, 34445);
                    if (resultCart)
                    {
                        Console.WriteLine("Product Added to Cart");
                    }
                    bool resultCheckOut = client.CheckOut(767867);
                    if (resultCheckOut)
                    {
                        Console.WriteLine("Order Placed");
                    }
                    bool resultReview = client.ReviewCart(345436);
                    if (resultReview)
                    {
                        Console.WriteLine("Cart review successfull");
                    }                 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
