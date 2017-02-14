using System;
using Xunit;
using CoinCombinationApp.Objects;
using System.Collections.Generic;
using System.IO;

namespace CoinTestApp
{
    public class CoinTestApp : IDisposable
    {
        [Fact]
        public void IsCoin_ReturningPennies_Pennies()
        {
            int change = 4;

            Coins newCoin = new Coins(change);
            int result = newCoin.GetPenny();
            Assert.Equal(change, result);
        }

        [Fact]
        public void IsCoin_ReturningNickels_Nickels()
        {
            int change = 5;
            int changeResult = change / 5;

            Coins newCoin = new Coins(change);
            int result = newCoin.GetNickel();
            Assert.Equal(changeResult, result);
        }

        [Fact]
        public void IsCoin_ReturningDimes_Dimes()
        {
            int change = 10;
            int changeResult = change / 10;

            Coins newCoin = new Coins(change);
            int result = newCoin.GetDime();
            Assert.Equal(changeResult, result);
        }

        [Fact]
        public void IsCoin_ReturningQuarter_Quarter()
        {
            int change = 25;
            int changeResult = change / 25;

            Coins newCoin = new Coins(change);
            int result = newCoin.GetQuarter();
            Assert.Equal(changeResult, result);
        }

        [Fact]
        public void IsCoin_ReturningAll_All()
        {
            int change = 100;
            List<int> changeResult = new List<int>();
            changeResult.Add(4);
            changeResult.Add(0);
            changeResult.Add(0);
            changeResult.Add(0);


            Coins newCoin = new Coins(change);
            List<int> result = Coins.GetAll();

            Assert.Equal(changeResult, result);
        }
        
        public void Dispose()
        {
          Coins.DeleteAll();
        }
    }
}
