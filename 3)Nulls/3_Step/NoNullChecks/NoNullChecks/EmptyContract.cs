using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoNullChecks
{
    public class EmptyContract: IContract
    {
        private static EmptyContract instance;

        private EmptyContract()
        {
        }

        public static EmptyContract Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmptyContract();
                }

                return instance;
            }
        }

        public void Check(DateTime checkMoment, Action onSuccesfullCheck)
        {
        }
    }
}
