public class NotificationService
{
    private readonly IMessageSender _sender;

    // Constructor Injection
    public NotificationService(IMessageSender sender)
    {
        // The actual implementation (EmailSender or SmsSender) will be injected by the DI container.
        _sender = sender;
    }

    public void Notify(string message)
    {
        _sender.Send(message);
    }
}
