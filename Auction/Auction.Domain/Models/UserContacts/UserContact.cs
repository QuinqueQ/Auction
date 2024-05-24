using Auction.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Domain.Models.UserContacts
{
    public class UserContact : Entity
    {
        public long UserId { get; set; }

        public string? Email { get; set; }

        public required string PhoneNumber { get; set; }
        public string? Telegram { get; set; }
        public string? Instagram { get; set; }

        public string? City { get; set; }

        public string? Country { get; set; }
    }
}
