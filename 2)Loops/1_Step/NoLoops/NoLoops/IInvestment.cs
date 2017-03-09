using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoLoops
{
    public interface IInvestment
    {
        InvestmentType InvestmentType { get; set; }
        double Price { get; set; }
        double PercentOfValueCahnge { get; set; }
        double YearlyCost { get; set; }
        
    }


}
