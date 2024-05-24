using Auction.Domain.Abstractions;
using Auction.Domain.Models.Services;
using Auction.Domain.Models.Users;


namespace Auction.Domain.Models.AuctionLots.ServiceAuctions
{
    public class ServiceAuction : Entity
    {
        public long LotId { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public required Service Service { get; set; }
        public required decimal StartingPrice { get; set; }
        public decimal CurrentPrice { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public User? CurrentWinner { get; set; }
    }
}
