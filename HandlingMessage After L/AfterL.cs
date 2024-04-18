using System;

class MessageHandler
{
    public virtual void SendMessage(string message, string recipient)
    {
        Console.WriteLine($"Sending message to {recipient}: {message}");
    }

    public virtual void ReceiveMessage(string message, string sender)
    {
        Console.WriteLine($"Receiving {message} from {sender}");
    }

    public virtual void DisplayMessage(string message)
    {
        Console.WriteLine($"{message}");
    }
}

class MessageReceiver : MessageHandler
{
    public override void SendMessage(string message, string recipient)
    {
        Console.WriteLine($"Sending message to {recipient}: {message}");
    }

    public override void ReceiveMessage(string message, string sender)
    {
        Console.WriteLine($"Receiving {message} from {sender}");
    }

    public override void DisplayMessage(string message)
    {
        Console.WriteLine($"{message}");
    }
}

class AfterL
{
    static void Main()
    {
        MessageHandler sender = new MessageReceiver();
        sender.SendMessage("Hello there!", "Alice");

        MessageHandler receiver = new MessageReceiver();
        receiver.ReceiveMessage("Hi!", "Bob");

        MessageHandler displayer = new MessageReceiver();
        displayer.DisplayMessage("This is a displayed message.");
    }
}