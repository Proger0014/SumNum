using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SumNum.BusinessLogic;

namespace SumNum.API
{
    public class SumTwoNums2 : ISumTwoNums
    {
        public int Sum(int a, int b)
        {
            SumClass sumClass = new SumClass();

            return sumClass.Sum2(a, b);
        }
    }
}
