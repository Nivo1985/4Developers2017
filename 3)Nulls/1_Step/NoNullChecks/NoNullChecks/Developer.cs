using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoNullChecks
{
    class Developer
    {
        public Contract WorkContract { get; }
        public Contract SupportContract { get; }


        public Developer(Contract workContract, Contract supportContract)
        {
            this.WorkContract = workContract;
            this.SupportContract = supportContract;
        }
    }
}
