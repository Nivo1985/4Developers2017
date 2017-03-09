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
                .Optional(x => x.GetIncomeAfterPeriod(numberOfYears));


            //double optimalValue = double.MinValue;
            //IInvestment bestInvestment = null;
            //foreach (var investment in investments)
            //{
            //    if (investment.InvestmentType == type)
            //    {
            //        var incomeAfterPeriod = investment.Price*
            //                                Math.Pow(1 + investment.PercentOfValueCahnge, numberOfYears) -
            //                                investment.Price - investment.YearlyCost*numberOfYears;

            //        if (bestInvestment == null || incomeAfterPeriod > optimalValue)
            //        {
            //            bestInvestment = investment;
            //        }
            //    }        
            //}

            //return bestInvestment;
        }
    }
}
