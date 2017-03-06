using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_Step.Interfaces;

namespace _3_Step.StatesClasses
{
    class Active: ISuspendable
    {
        private Action OnActivation { get; }

        public Active(Action onActivation)
        {
            this.OnActivation = onActivation;
        }

        public ISuspendable SignFile() => this;

        public ISuspendable AddRequirement() => this;

        public ISuspendable Suspend() => new Suspended(this.OnActivation);
    }
}
