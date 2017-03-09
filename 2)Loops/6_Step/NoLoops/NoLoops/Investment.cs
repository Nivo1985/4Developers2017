using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoLoops
{
    class Investment:IInvestment
    {
        public InvestmentType InvestmentType { get; set; }
        public double Price { get; set; }
        public double PercentOfValueCahnge { get; set; }
        public double YearlyCost { get; set; }
        public double GetIncomeAfterPeriod(double years)
        {
            var result = this.Price * Math.Pow(1 + this.PercentOfValueCahnge, years)
                - this.Price
                - this.YearlyCost*years;

            return result;
        }
    }
}
