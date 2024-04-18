using System;

interface ISendMessage
{
    void SendMessage(string message, string recipient);
}

interface IReceiveMessage
{
    void ReceiveMessage(string message, string sender);
}

interface IDisplayMessage
{
    void DisplayMessage(string message);
}

class MessageSender : ISendMessage
{
    public void SendMessage(string message, string recipient)
    {
        Console.WriteLine($"Sending message to {recipient}: {message}");
    }
}

class MessageReceiver : IReceiveMessage
{
    public void ReceiveMessage(string message, string sender)
    {
        Console.WriteLine($"Receiving {message} from {sender}");
    }
}

class DisplayingMessages : IDisplayMessage
{
    public void DisplayMessage(string message)
    {
        Console.WriteLine($"{message}");
    }
}

class AfterI
{
    static void Main()
    {
        ISendMessage sender = new MessageSender();
        sender.SendMessage("Hello there!", "Alice");

        IReceiveMessage receiver = new MessageReceiver();
        receiver.ReceiveMessage("Hi!", "Bob");

        IDisplayMessage displayer = new DisplayingMessages();
        displayer.DisplayMessage("This is a displayed message.");
    }
}