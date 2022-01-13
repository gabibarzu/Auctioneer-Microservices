﻿using System.Collections.Generic;
using System.Linq;

using AccountApi.Entities;

namespace AccountApi.Services.Extensions
{
    public static class BidExtensions
    {
        public static int GetTotalNumberOfBids(this List<Bid> bids)
        {
            return bids.Count;
        }

        public static decimal GetHighestBid(this List<Bid> bids)
        {
            return bids.Max(bid => bid.Value);
        }

        public static decimal GetLowestBid(this List<Bid> bids)
        {
            return bids.Min(bid => bid.Value);
        }

        public static decimal GetTotalMoneySpent(this List<Bid> bids)
        {
            return bids.Sum(bid => bid.Value);
        }

    }
}