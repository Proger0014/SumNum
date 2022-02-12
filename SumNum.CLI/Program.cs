using System;
using SumNum.BusinessLogic;

namespace SumNum.CLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumClass.Sum(1, 3));
        }
    }
}
