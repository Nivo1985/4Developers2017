using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_Step.Interfaces;
using _4_Step.StatesClasses;

namespace _3_Step.StatesClasses
{
    class Active: IRequestFileState
    {
        private Action OnActivation { get; }

        public Active(Action onActivation)
        {
            this.OnActivation = onActivation;
        }

        public IRequestFileState SignFile(Action setOwner)
        {
            setOwner();
            return this;
        }

        public IRequestFileState AddRequirement(Action addRequ)
        {
            addRequ();
            return this;
        }

        public IRequestFileState Suspend() => new Suspended(this.OnActivation);
        public IRequestFileState Validate() => this;

        public IRequestFileState Finish() => new Finished();
    }
}
