using System;

namespace _3_Step.Interfaces
{
    public interface IRequestFileState
    {
        IRequestFileState SignFile(Action setOwner);
        IRequestFileState AddRequirement(Action addRequ);
        IRequestFileState Suspend();

        IRequestFileState Validate();
        IRequestFileState Finish();
    }
}