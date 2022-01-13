using System.Collections.Generic;

using AccountApi.Entities;
using AccountApi.Services.Interfaces;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AccountApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IAccountService _service;

        public AccountController(IAccountService service)
        {
            this._service = service;
        }

        // GET: api/<AccountController>/GetAccountStat
        [HttpGet]
        [Authorize]
        public AccountStat GetAccountStat()
        {
            return this._service.GetAccountStat();
        }

        // GET: api/<AccountController>/GetProducts
        [HttpGet]
        [Authorize]
        public List<Product> GetProducts()
        {
            return this._service.GetProducts();
        }
    }
}