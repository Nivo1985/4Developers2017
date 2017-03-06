namespace _3_Step.Interfaces
{
    public interface ISuspendable
    {
        ISuspendable SignFile();
        ISuspendable AddRequirement();
        ISuspendable Suspend();
    }
}