using Contracts;

namespace ApiGateway.Controllers
{
    public class BuyItemsRequstModel : BuyItemsRequest
    {
        public Guid OrderId { get; set; }

        public int Count { get; set; }

        public decimal Amount { get; set; }
    }
}
