using Rockseatauction.API.Entitys;
using Microsoft.EntityFrameworkCore;
using Rockseatauction.API.Repositories;

namespace Rockseatauction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public Auction? Execute()
    {
        var repository = new RocketSeatAuctionDBContext();

        var today = DateTime.Now;

        return repository
            .Auctions
            .Include(auction => auction.Items)
            .First();
       
    }
}
