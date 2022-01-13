using System;
using System.Collections.Generic;

using ProductsApi.Entities;

namespace ProductsApi.Services.Interfaces
{
    public interface IBidService
    {
        public decimal GetCurrentBidValue(Guid productId);
        public bool Bid(Bid bid);
        public bool Buy(Bid bid);
        public List<Bid> GetAllBidsForProduct(Guid productId);
    }
}
