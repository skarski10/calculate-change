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
        private int _dime;
        private int _quarter;
        private static List<int> _changeList = new List<int>();

        public Coins(int userInput)
        {
            _userInput = userInput;
            if(_userInput % 25 >= 0)
            {
                _quarter = _userInput / 25;
                _userInput = userInput % 25;
                _changeList.Add(_quarter);
            }
            if(_userInput % 10 >= 0)
            {
                _dime = _userInput / 10;
                _userInput = _userInput % 10;
                _changeList.Add(_dime);
            }
            if(_userInput % 5 >= 0)
            {
                _nickel = _userInput / 5;
                _userInput = userInput % 5;
                _changeList.Add(_nickel);
            }
            if(_userInput >= 0)
            {
                _penny = _userInput;
                _changeList.Add(_penny);
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

        public int GetDime()
        {
            return _dime;
        }

        public int GetQuarter()
        {
            return _quarter;
        }

        public static List<int> GetAll()
        {
            return _changeList;
        }

        public static void DeleteAll()
        {
            _changeList.Clear();
        }
    }
}
