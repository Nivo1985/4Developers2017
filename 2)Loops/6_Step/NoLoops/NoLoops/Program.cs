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
            var investments = new List<IInvestment>()
            {
                new Investment()
                {
                    InvestmentType = InvestmentType.Cars,
                    PercentOfValueCahnge = (double)0.01,
                    Price = 200,
                    YearlyCost = 500
                },
                new Investment()
                {
                    InvestmentType = InvestmentType.Cars,
                    PercentOfValueCahnge = (double)0.02,
                    Price = 100,
                    YearlyCost = 600
                },
                new Investment()
                {
                    InvestmentType = InvestmentType.Cars,
                    PercentOfValueCahnge = (double)0.40,
                    Price = 1000,
                    YearlyCost = 150
                },
                new Investment()
                {
                    InvestmentType = InvestmentType.Cars,
                    PercentOfValueCahnge = (double)0.03,
                    Price = 100,
                    YearlyCost = 550
                },
            };

            var bestInvestment = FindInvestmentForPeriod(5, InvestmentType.Cars, investments);
            Console.ReadKey();
        }

        private static IInvestment FindInvestmentForPeriod(double numberOfYears, InvestmentType type, IEnumerable<IInvestment> investments)
        {
            return investments.Where(x => x.InvestmentType == type)
                .Optional(x => x.GetIncomeAfterPeriod(numberOfYears));
        }
    }
}
