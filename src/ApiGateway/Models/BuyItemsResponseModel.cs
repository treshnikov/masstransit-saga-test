using Contracts;

namespace ApiGateway.Controllers
{
    public class BuyItemsResponseModel : BuyItemsResponse
    {
        public Guid OrderId { get; set; }

        public string ErrorMessage { get; set; }
    }
}
