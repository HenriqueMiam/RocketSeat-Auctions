using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.API.Filters;
using Rockseatauction.API.Communication.Requests;

namespace Rockseatauction.API.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttibute))]
public class OfferController : RocketSeatAuctionBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    
    public IActionResult CreateOffer([FromRoute]int itemId, [FromBody] RequestCreatedOfferJson request)
    {
        return Created();
    }

}
