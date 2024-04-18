using System;
using Console = System.Console;
class MessageSender
{
    public void SendMessage(string message, string recipient)
    {
        Console.WriteLine($"Sending message to {recipient}: {message}");
    }
}

class MessageReceiver
{
    public void ReceiveMessage(string message, string sender)
    {
        Console.WriteLine($"Receiving {message} from {sender}");
    }
}

class DisplayingMessages
{
    public void DisplayMessage(string message)
    {
        Console.WriteLine($"{message}");
    }
}

class AfterS
{
    static void Main()
    {
        MessageSender sender = new MessageSender();
        sender.SendMessage("Hello there!", "Alice");

        MessageReceiver receiver = new MessageReceiver();
        receiver.ReceiveMessage("Hi!", "Bob");

        DisplayingMessages displayer = new DisplayingMessages();
        displayer.DisplayMessage("This is a displayed message.");
    }
}