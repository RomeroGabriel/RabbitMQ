using MicroRabbit.Baking.Application.Interfaces;
using MicroRabbit.Baking.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MicroRabbit.Banking.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BankingController
    {
        private readonly IAccountServices accountService;

        public BankingController(IAccountServices accountService)
        {
            this.accountService = accountService;
        }

        [HttpGet]
        public IEnumerable<Account> Get()
        {
            return accountService.GetAccounts();
        }
    }
}
