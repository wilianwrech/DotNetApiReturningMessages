namespace ReturningMessages;

public class NotfoundException : Exception
{
    public NotfoundException(string message): base(message + " was not found")
    {
    }
}
