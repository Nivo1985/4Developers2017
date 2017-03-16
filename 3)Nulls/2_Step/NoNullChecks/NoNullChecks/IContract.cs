using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoNullChecks
{
    interface IContract
    {
        bool IsObligatory(DateTime checkMoment);
    }
}
