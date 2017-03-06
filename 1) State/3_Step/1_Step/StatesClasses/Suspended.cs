using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_Step.Interfaces;

namespace _3_Step.StatesClasses
{
    class Suspended: ISuspendable
    {
        private Action OnActivation { get; }

        public Suspended(Action onActivation)
        {
            this.OnActivation = onActivation;
        }

        public ISuspendable SignFile()
        {
            this.OnActivation();
            return new Active(this.OnActivation);
        }

        public ISuspendable AddRequirement()
        {
            this.OnActivation();
            return new Active(this.OnActivation);
        }

        public ISuspendable Suspend() => this;
    }
}
