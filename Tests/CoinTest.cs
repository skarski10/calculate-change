using System;
using Xunit;
using CoinCombinationApp.Objects;
using System.Collections.Generic;
using System.IO;

namespace CoinTestApp
{
  public class CoinTestApp
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
      Coins.ClearAll();
    }

    [Fact]
    public void IsCoin_ReturningDimes_Dimes()
    {
      int change = 10;
      int changeResult = change / 10;

      Coins newCoin = new Coins(change);
      int result = newCoin.GetDime();
      Assert.Equal(changeResult, result);
      Coins.ClearAll();
    }

    [Fact]
    public void IsCoin_ReturningQuarter_Quarter()
    {
      int change = 25;
      int changeResult = change / 25;

      Coins newCoin = new Coins(change);
      int result = newCoin.GetQuarter();
      Assert.Equal(changeResult, result);
      Coins.ClearAll();
    }

    [Fact]
    public void IsCoin_ReturningAll_All()
    {
      int change = 41;
      List<int> changeResult = new List<int>();
      changeResult.Add(1);
      changeResult.Add(1);
      changeResult.Add(1);
      changeResult.Add(1);


      Coins newCoin = new Coins(change);
      List<int> result = Coins.GetAll();

      Assert.Equal(changeResult, result);
      Coins.ClearAll();
    }
  }
}
