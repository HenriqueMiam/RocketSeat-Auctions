using Microsoft.EntityFrameworkCore;
using Rockseatauction.API.Entitys;

namespace Rockseatauction.API.Repositories;

public class RocketSeatAuctionDBContext : DbContext
{

    public DbSet<Auction> Auctions { get; set; }
    public DbSet<User> Users { get; set; }

    public DbSet<Offer> Offers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=D:\WorkSpace\leilaoDbNLW.db");
    }
}
