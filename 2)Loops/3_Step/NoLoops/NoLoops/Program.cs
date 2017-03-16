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
                .Aggregate((optimal, next)=>
                optimal.GetIncomeAfterPeriod(numberOfYears) > next.GetIncomeAfterPeriod(numberOfYears)?
                optimal : next);
        }
    }
}
