namespace MerchandiseService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MerchandiseService : IMerchandiseService
    {
        public bool AddToCart(long loginId, long productId)
        {
            return true;
        }
        public bool CheckOut(long CartId)
        {
            return true;
        }
        public long Login(string loginName, string password)
        {
            return 10001;
        }
        public bool ReviewCart(long cartId)
        {
            return true;
        }
    }
}
