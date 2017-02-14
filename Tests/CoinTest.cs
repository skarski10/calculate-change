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
    }
  }
}
