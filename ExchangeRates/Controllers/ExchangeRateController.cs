using ExchangeRates.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeRates.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExchangeRateController : Controller
    {
        private IExchangeRateService _service;


        public ExchangeRateController(IExchangeRateService service)
        {
            _service = service;

        }
        [HttpGet("/api/exchange-rate")]
        public Task<string> GetExchangeRate()
        {
            return _service.GetExchangeRateAsync();
        }
    }
}
