using Auction.Domain.Abstractions;
using Auction.Domain.Enums.PurchaseEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Domain.Models.PurchaseActs
{
    public class PurchaseAct : Entity
    {
        public long PurchaseId { get; set; }

        public required long LotId { get; set; }

        public required string BuyerName { get; set; }

        public required string SellerName { get; set; }

        public required decimal Price { get; set; }

        public DateTime TransactionDate { get; set; }

        public PurchaseStatus Status { get; set; } = PurchaseStatus.InProgress;
    }
}
