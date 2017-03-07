using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_Step.Interfaces;

namespace _4_Step.StatesClasses
{
    class Finished: IRequestFileState
    {
        public IRequestFileState SignFile(Action setOwner) => this;

        public IRequestFileState AddRequirement(Action addRequ) => this;

        public IRequestFileState Suspend() => this;

        public IRequestFileState Validate() => this;

        public IRequestFileState Finish() => this;
    }
}
