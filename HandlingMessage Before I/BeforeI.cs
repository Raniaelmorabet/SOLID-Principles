using System;

interface IMessageService
{
    void SendMessage(string message, string recipient);
    void ReceiveMessage(string message, string sender);
    void DisplayMessage(string message);
}

class MessageReceiver : IMessageService
{
    public void SendMessage(string message, string recipient)
    {
        Console.WriteLine($"Sending message to {recipient}: {message}");
    }

    public void ReceiveMessage(string message, string sender)
    {
        Console.WriteLine($"Receiving {message} from {sender}");
    }

    public void DisplayMessage(string message)
    {
        Console.WriteLine($"{message}");
    }
}

class BeforeI
{
    static void Main()
    {
        IMessageService messageService = new MessageReceiver();

        messageService.SendMessage("Hello there!", "Alice");
        messageService.ReceiveMessage("Hi!", "Bob");
        messageService.DisplayMessage("This is a displayed message.");
    }
}