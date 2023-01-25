using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeRates.Services
{
    public interface IExchangeRateService
    {
        Task<string> GetExchangeRateAsync();
    }
}
