namespace Traveller.Commands.Contracts
{
    public interface ICommandProcessor
    {
        void ProcessCommand(string commandAsString);
    }
}
