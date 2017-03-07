using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using _3_Step.Interfaces;
using _3_Step.StatesClasses;

namespace _4_Step.StatesClasses
{
    class InValid : IRequestFileState
    {
        private Action OnActivation { get; set; }

        public InValid(Action onActivation)
        {
            this.OnActivation = onActivation;
        }

        public IRequestFileState SignFile(Action setOwner)
        {
            setOwner();
            return this;
        }

        public IRequestFileState AddRequirement(Action addRequ) => this;

        public IRequestFileState Suspend() => this;

        public IRequestFileState Validate() => new Active(this.OnActivation);

        public IRequestFileState Finish() => new Finished();
    }
}
