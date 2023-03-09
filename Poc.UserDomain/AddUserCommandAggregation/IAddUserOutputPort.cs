namespace Poc.UserDomain.AddUserCommandAggregation
{
    public interface IAddUserOutputPort
    {
        void OnSuccess();
        void OnFailure(string message);
        void OnError(Exception exception);
    }
}
