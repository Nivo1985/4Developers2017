using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoLoops
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static IInvestment FindInvestmentForPeriod(double numberOfYears, InvestmentType type, IEnumerable<IInvestment> investments)
        {
            return investments.Where(x => x.InvestmentType == type)
                .Optimal(x => x.GetIncomeAfterPeriod(numberOfYears));
        }
    }
}
