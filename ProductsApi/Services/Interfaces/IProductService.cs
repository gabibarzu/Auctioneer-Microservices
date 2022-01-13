using System;
using System.Collections.Generic;

using ProductsApi.Entities;

namespace ProductsApi.Services.Interfaces
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetProductById(Guid id);
        List<Product> GetProductsBySearchCriteria(SearchCriteria request);
        List<Product> GetAllBidProducts();
    }
}