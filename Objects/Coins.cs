using System.Collections.Generic;
using System;
using System.IO;

namespace CoinCombinationApp.Objects
{
  public class Coins
  {
    private int _userInput;
    private int _penny;
    private int _nickel;
    // private int _dime;
    // private int _quarter;

    public Coins(int userInput)
    {
      _userInput = userInput;

      if(userInput % 5 == 0)
      {
        _nickel = userInput / 5;
      }
      else
      {
        _penny = userInput;
      }
    }

    public int GetPenny()
    {
      return _penny;
    }

    public int GetNickel()
    {
      return _nickel;
    }
  }
}
