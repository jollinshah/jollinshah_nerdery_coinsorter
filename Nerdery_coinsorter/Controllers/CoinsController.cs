using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Nerdery_coinsorter.Models;

namespace Nerdery_coinsorter.Controllers
{
    public class CoinsController : ApiController
    {
        Coin[] coins = new Coin[]
        {
            new Coin { CoinType = "Silver Dollar", CoinValue = 1.00m  },
            new Coin { CoinType = "half dollar", CoinValue = 0.50m  },
            new Coin { CoinType = "quarter", CoinValue = 0.25m  },
            new Coin { CoinType = "dime", CoinValue = 0.10m  },
            new Coin { CoinType = "nickel", CoinValue = 0.05m  },
            new Coin { CoinType = "penny", CoinValue = 0.01m  },
        };

        public IEnumerable<Coin> GetAllCoins()
        {
            return coins;
        }
        
        public IHttpActionResult GetCoins(decimal totalamount)
        {
            decimal amt_remaining = totalamount;
            foreach (var coin in coins)
            {
                if (amt_remaining < coin.CoinValue) continue;
                var coin_quotient = (int)(amt_remaining / coin.CoinValue);
                //return Ok(new string('-', 28));
                //return Ok("{0,10}{1,15}", coin.CoinType, coin_quotient);
                Console.WriteLine(new string('-', 28));
                Console.WriteLine("{0,10}{1,15}", coin.CoinType, coin_quotient);
                amt_remaining -= coin_quotient * coin.CoinValue;
                if (amt_remaining <= 0) break;
            }
            // return Ok(new string('-', 28));
            Console.WriteLine(new string('-', 28));
            return Ok(amt_remaining);
        }
    }
}
