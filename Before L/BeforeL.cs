using System;

class MessageHandler
{
    public  void SendMessage(string message, string recipient)
    {
        Console.WriteLine($"Sending message to {recipient}: {message}");
    }

    public virtual void ReceiveMessage(string message, string sender)
    {
        Console.WriteLine($"Receiving {message} from {sender}");
    }

    public  void DisplayMessage(string message)
    {
        Console.WriteLine($"{message}");
    }
}

class MessageReceiver : MessageHandler
{
    public override void ReceiveMessage(string message, string sender)
    {
        Console.WriteLine($"Receiving {message} from {sender}");
    }
}

class BeforeL
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