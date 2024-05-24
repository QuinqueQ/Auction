using Auction.Domain.Abstractions;
using Auction.Domain.Models.Products;
using Auction.Domain.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Domain.Models.AuctionLots.ProductAuctions
{
    public class ProductAuction : Entity
    {
        public long LotId { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public required Product Product { get; set; }
        public required decimal StartingPrice { get; set; }
        public decimal CurrentPrice { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public User? CurrentWinner { get; set; }
    }
}
