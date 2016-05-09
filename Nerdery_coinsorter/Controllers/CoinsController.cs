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
            new Coin { CoinType = "Silver Dollar", CoinValue = 1.00M  },
            new Coin { CoinType = "Half dollar", CoinValue = 0.50M  },
            new Coin { CoinType = "Quarter", CoinValue = 0.25M  },
            new Coin { CoinType = "Dime", CoinValue = 0.10M  },
            new Coin { CoinType = "Nickel", CoinValue = 0.05M  },
            new Coin { CoinType = "Penny", CoinValue = 0.01M },
        };

        public IEnumerable<Coin> GetAllCoins()
        {
            return coins;
        }
    }
}
