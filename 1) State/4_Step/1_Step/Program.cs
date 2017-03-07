using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Step
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new RequestFile(() =>
            {
                Console.WriteLine("Request File activated");
            });
            
            file.SignFile("Karol Rogowski");
            file.ValidateFile();
            file.Suspend();
            file.AddRequirement(new {requ = "Information about requirement"});
            file.AddRequirement(new { requ = "Information about requirement 2" });
            file.AddRequirement(new { requ = "Information about requirement 3" });
            Console.ReadKey();
        }
    }
}
