using System;

namespace ProductsApi.Entities
{
    public class LatestDeals
    {
        public Guid ProductId { get; set; }
        public Guid CategoryId { get; set; }
    }
}