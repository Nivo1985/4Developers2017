using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using _3_Step.Interfaces;
using _3_Step.StatesClasses;
using _4_Step.StatesClasses;

namespace _3_Step
{
    class RequestFile
    {
        private string Owner { get; set; }
        private List<object> Requirements { get; set; }
        private IRequestFileState RequestFileState { get; set; }

        public RequestFile(Action onActivaton)
        {
            this.Requirements = new List<object>();
            this.RequestFileState = new InValid(onActivaton);
        }

        public void SignFile(string owner)
        {

            this.RequestFileState = this.RequestFileState.SignFile(() => this.Owner = owner);
        }

        public void AddRequirement(object requ)
        {

            this.RequestFileState = this.RequestFileState.AddRequirement(() => this.Requirements.Add(requ));
        }

        public void ValidateFile()
        {
            this.RequestFileState = this.RequestFileState.Validate();
        }

        public void Finish()
        {
            this.RequestFileState = this.RequestFileState.Finish();
        }

        public void Suspend()
        {
            this.RequestFileState = this.RequestFileState.Suspend();
        }
    }
}
