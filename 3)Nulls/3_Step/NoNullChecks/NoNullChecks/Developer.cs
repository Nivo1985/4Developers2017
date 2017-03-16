using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoNullChecks
{
    class Developer
    {
        public IContract WorkContract { get; private set; }
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

        public void OnlySupportNeeded()
        {
            this.WorkContract = EmptyContract.Instance;
        }


    }
}
