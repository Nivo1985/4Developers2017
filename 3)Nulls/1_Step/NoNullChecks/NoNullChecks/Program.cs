using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace NoNullChecks
{
    class Program
    {
        static void CheckDeveloperState(Developer contract, bool onlySupportNeeded)
        {
            var now = DateTime.UtcNow;

            if (!onlySupportNeeded 
                && contract.WorkContract !=null
                && contract.WorkContract.IsObligatory(now))
            {
                Console.WriteLine("Developer on full obligatory");
            }

            if (contract.SupportContract != null
                && contract.SupportContract.IsObligatory(now))
            {
                Console.WriteLine("Developper will support us");
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
