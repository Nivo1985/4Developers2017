using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoNullChecks
{
    interface IContract
    {
        void Check(DateTime checkMoment, Action onSuccesfullCheck);
    }
}
