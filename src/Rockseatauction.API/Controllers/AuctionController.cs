using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Rockseatauction.API.Entitys;
using Rockseatauction.API.UseCases.Auctions.GetCurrent;
using System.Reflection.Metadata.Ecma335;

namespace Rockseatauction.API.Controllers;


public class AuctionController : RocketSeatAuctionBaseController
{
    [HttpGet]
    [ProducesResponseType(typeof(Auction),StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetCurrentauction()
    {
        var useCase = new GetCurrentAuctionUseCase();

       var result= useCase.Execute();

        if (result is null)
            return NoContent();

        return Ok(result);

    }
}
