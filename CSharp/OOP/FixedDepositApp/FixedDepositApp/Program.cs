using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FixedDepositApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fixedAccount = new FixedDeposit("account1",1000,2,Festival.HOLI);
            Console.WriteLine("name "+   fixedAccount.Name);
            Console.WriteLine("Principle "+fixedAccount.Principle);
            Console.WriteLine("Year "+fixedAccount.year);
            Console.WriteLine("festival "+fixedAccount.FEstival);
            Console.WriteLine("simple interest "+fixedAccount.CalculateSimpleInterest());
        }
    }
}
