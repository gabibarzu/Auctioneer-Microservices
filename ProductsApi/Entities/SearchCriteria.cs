using System;

namespace ProductsApi.Entities
{
    public class SearchCriteria
    {
        public Guid CategoryId { get; set; }
        public string SearchText { get; set; }
    }
}