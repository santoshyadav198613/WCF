using System.ServiceModel;

namespace MerchandiseService
{
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface IMerchandiseService
    {
        [OperationContract(IsInitiating = true, IsTerminating = false)]
        long Login(string loginName, string password);

        [OperationContract(IsInitiating = false, IsTerminating = false)]
        bool AddToCart(long loginId, long productId);

        [OperationContract(IsInitiating = false, IsTerminating = false)]
        bool ReviewCart(long cartId);

        [OperationContract(IsInitiating = false, IsTerminating = true)]
        bool CheckOut(long CartId);
    }
}
