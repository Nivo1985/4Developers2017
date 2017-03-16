using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoNullChecks
{
    public class LifetimeContract : IContract
    {
        private DateTime StartDate { get; }

        public LifetimeContract(DateTime startDate)
        {
            this.StartDate = startDate;
        }

        public void Check(DateTime checkMoment, Action onSuccesfullCheck)
        {
            if (IsObligatory(checkMoment))
            {
                onSuccesfullCheck();
            }
        }

        private bool IsObligatory(DateTime checkMoment) =>
            this.StartDate <= checkMoment;
    }
}
