using System.Collections.Generic;

using AccountApi.Entities;

namespace AccountApi.Services.Interfaces
{
    public interface IAccountService
    {
        AccountStat GetAccountStat();
        List<Product> GetProducts();
    }
}