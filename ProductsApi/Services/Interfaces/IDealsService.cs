using System.Collections.Generic;

using ProductsApi.Entities;

namespace ProductsApi.Services.Interfaces
{
    public interface IDealsService
    {
        public List<Product> LatestDeals(LatestDeals request);
    }
}
