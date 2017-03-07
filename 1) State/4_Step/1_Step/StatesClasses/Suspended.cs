using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_Step.Interfaces;
using _4_Step.StatesClasses;

namespace _3_Step.StatesClasses
{
    class Suspended: IRequestFileState
    {
        private Action OnActivation { get; }

        public Suspended(Action onActivation)
        {
            this.OnActivation = onActivation;
        }

        public IRequestFileState SignFile(Action setOwner)
        {
            this.OnActivation();
            setOwner();
            return new Active(this.OnActivation);
        }

        public IRequestFileState AddRequirement(Action addRequ)
        {
            this.OnActivation();
            addRequ();
            return new Active(this.OnActivation);
        }

        public IRequestFileState Suspend() => this;
        public IRequestFileState Validate() =>new Active(this.OnActivation);

        public IRequestFileState Finish() => new Finished();
    }
}
