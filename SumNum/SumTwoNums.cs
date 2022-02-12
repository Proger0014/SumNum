using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SumNum.BusinessLogic;

namespace SumNum.API
{
    public class SumTwoNums : ISumTwoNums
    {
        public int Sum(int a, int b)
        {
            var sumClass = new SumClass();

            return sumClass.Sum(a, b);
        }
    }
}
