using MicroRabbit.Baking.Application.Interfaces;
using MicroRabbit.Baking.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(accountService.GetAccounts());
        }
    }
}
