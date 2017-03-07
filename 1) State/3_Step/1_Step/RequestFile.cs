using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using _3_Step.Interfaces;
using _3_Step.StatesClasses;

namespace _3_Step
{
    class RequestFile
    {
        private bool IsValid { get; set; }
        private bool IsFinished { get; set; }
        private string Owner { get; set; }
        private List<object> Requirements { get; set; }

        //private Action OnActivation { get; }
        private ISuspendable Suspendable { get; set; }

        public RequestFile(Action onActivaton)
        {
            this.Suspendable = new Active(onActivaton);
        }

        public void SignFile(string owner)
        {
            if (this.IsFinished)
            {
                return;
            }

            this.Suspendable =this.Suspendable.SignFile();

            this.Owner = owner;
        }

        public void AddRequirement(object requ)
        {
            if (!this.IsValid)
            {
                return;
            }

            if (this.IsFinished)
            {
                return;
            }

            this.Suspendable = this.Suspendable.AddRequirement();

            this.Requirements.Add(requ);
        }

        public void ValidateFile()
        {
            this.IsValid = true;
        }

        public void Finish()
        {
            this.IsFinished = true;
        }

        public void Suspend()
        {
            if (this.IsFinished)
            {
                return;
            }
            if (!this.IsValid)
            {
                return;
            }

            this.Suspendable = this.Suspendable.Suspend();
        }
    }
}
