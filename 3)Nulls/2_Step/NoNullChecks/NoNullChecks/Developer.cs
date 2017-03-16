using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoNullChecks
{
    class Developer
    {
        public IContract WorkContract { get; }
        public IContract SupportContract { get; }


        public Developer(IContract workContract, IContract supportContract)
        {
            if (workContract == null)
            {
                workContract = EmptyContract.Instance;
            }

            if (supportContract == null)
            {
                supportContract = EmptyContract.Instance;
            }

            this.WorkContract = workContract;
            this.SupportContract = supportContract;
        }
    }
}
