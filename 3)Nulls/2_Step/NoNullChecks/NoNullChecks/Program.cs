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
        static void CheckDeveloperState(Developer developer, bool onlySupportNeeded)
        {
            var now = DateTime.UtcNow;

            if (!onlySupportNeeded && developer.WorkContract.IsObligatory(now))
            {
                Console.WriteLine("Developer on full obligatory");
            }

            if (developer.SupportContract.IsObligatory(now))
            {
                Console.WriteLine("Developper will support us");
            }
        }

        static void Main(string[] args)
        {
            var yesterday = DateTime.Now.AddDays(-1);
            var daysOfWork = 5;
            var daysOdSupport = 20;

            IContract workContract = new SignedContract(yesterday,daysOfWork);
            IContract suppertContract = new SignedContract(yesterday, daysOdSupport);
            IContract emptyContract = EmptyContract.Instance;

            var firstDeveloper = new Developer(workContract,suppertContract);
            var second = new Developer(workContract, emptyContract);

            CheckDeveloperState(firstDeveloper,false);
            CheckDeveloperState(second,false);

            Console.ReadLine();
        }
    }
}
