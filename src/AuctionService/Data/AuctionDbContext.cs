using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data;

public sealed class AuctionDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }
    public AuctionDbContext(DbContextOptions options) 
        : base(options)
    {
    }
}
