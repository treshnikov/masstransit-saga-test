using Contracts;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace ApiGateway.Controllers
{
    [ApiController]
    [Route("api/v1/items")]
    public class ItemsController : ControllerBase
    {
        private readonly IBus _bus;
        private readonly ILogger<ItemsController> _logger;

        public ItemsController(IBus bus, ILogger<ItemsController> logger)
        {
            _bus = bus;
            _logger = logger;
        }

        [HttpPost("buy")]
        public async Task<BuyItemsResponse> BuyAsync(BuyItemsRequstModel model)
        {
            var response = await _bus.Request<BuyItemsRequest, BuyItemsResponse>(model);
            return response.Message;
        }
    }
}
