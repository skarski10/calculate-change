using System;
using System.Collections.Generic;
using Nancy;
using CoinCombinationApp.Objects;

namespace CoinCombinationApp
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                Coins.DeleteAll();
                return View["index.cshtml"];
            };

            Post["/"] = _ => {
                Coins newCoin = new Coins(Request.Form["input"]);
                List<int> result = Coins.GetAll();
                return View["index.cshtml", newCoin];
            };
        }
    }
}
