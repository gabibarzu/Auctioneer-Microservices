using System.Collections.Generic;
using System.Linq;

using ProductsApi.Database;
using ProductsApi.Entities;
using ProductsApi.Services.Extensions;
using ProductsApi.Services.Interfaces;

namespace ProductsApi.Services
{
    public class DealsService : IDealsService
    {
        private readonly DatabaseContext _context;

        public DealsService(DatabaseContext context)
        {
            this._context = context;
        }

        public List<Product> LatestDeals(LatestDeals request)
        {
            return this._context.Products.Where(product => product.Id != request.ProductId && product.CategoryId == request.CategoryId)
                .OnlyAvailable()
                .OrderByDescending(product => product.EndTime)
                .Take(4)
                .ToList();
        }
    }
}
