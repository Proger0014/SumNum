using SumNum.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNum.API
{
    public class SumTwoNums3 : ISumTwoNums
    {
        public int Sum(int a, int b)
        {
            SumClass sumClass = new SumClass();

            return sumClass.Sum3(a, b);
        }
    }
}
