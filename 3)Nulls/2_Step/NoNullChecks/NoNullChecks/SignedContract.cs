using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoNullChecks
{
    public class SignedContract: IContract
    {
        private DateTime StartDate { get; }
        private int DaysToLast { get; }

        public SignedContract(DateTime startDate, int daysToLast)
        {
            this.StartDate = startDate;
            this.DaysToLast = daysToLast;
        }

        public bool IsObligatory(DateTime checkMoment) =>
            StartDate <= checkMoment && checkMoment <= StartDate.AddDays(DaysToLast);
    }
}
