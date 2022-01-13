using System;
using System.Collections.Generic;

using ProductsApi.Entities;

namespace ProductsApi.Services.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        Category GetCategoryById(Guid categoryId);
    }
}
