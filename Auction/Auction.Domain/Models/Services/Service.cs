using Auction.Domain.Abstractions;
using Auction.Domain.Enums.ServiceEnums;
using Auction.Domain.Models.UserContacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Domain.Models.Services
{
    public class Service : Entity
    {
        public long ServiceId { get; set; }

        public required string Name { get; set; }

        public required string Description { get; set; }

        public decimal Price { get; set; }

        public ServiceCategory? Category { get; set; }

        public required UserContact Contact { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
