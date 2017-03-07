using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2_Step
{
    class RequestFile
    {
        private bool IsValid { get; set; }
        private bool IsFinished { get; set; }
        private string Owner { get; set; }
        private List<object> Requirements { get; set; }

        private Action OnActivation { get; }
        private Action ActivationOperation { get; set; }

        public RequestFile(Action onActivaton)
        {
            this.OnActivation = onActivaton;

            this.ActivationOperation = this.RemainActive;
        }

        public void SignFile(string owner)
        {
            if (this.IsFinished)
            {
                return;
            }

            this.ActivationOperation();

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

            this.ActivationOperation();

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

            this.ActivationOperation = this.Activate;
        }


        private void Activate()
        {
            this.OnActivation();
            this.ActivationOperation = this.RemainActive;
        }

        private void RemainActive()
        {

        }
    }
}
