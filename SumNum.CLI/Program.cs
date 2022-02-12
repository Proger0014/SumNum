using System;
using SumNum.BusinessLogic;

namespace SumNum.CLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SumClass sumClass = new SumClass();

            Console.WriteLine(sumClass.Sum(1, 3));
        }
    }
}
