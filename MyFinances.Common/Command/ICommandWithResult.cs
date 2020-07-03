namespace MyFinances.Common.Command
{
    public interface ICommandWithResult<T> : ICommand
    {
        T Result { get; }
    }
}