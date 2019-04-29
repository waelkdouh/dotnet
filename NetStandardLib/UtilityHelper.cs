using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace NetStandardLib
{
    public class UtilityHelper
    {
        public int Calculate(int num1,int num2)
        {
            return num1 + num2;
        }

        public IEnumerable<int> CreateOneTwoThree()
        {
            return new Bag<int> { 1, 2, 3 };
        }
    }
}
