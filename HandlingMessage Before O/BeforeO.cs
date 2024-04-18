using System;
using Console = System.Console;

class MessageSender
{
    public void SendMessage(string message, string recipient)
    {
        // Existing code for sending message
        Console.WriteLine($"Sending message to {recipient}: {message}");

        // New code added for logging directly within the class
        Console.WriteLine($"Logging: Message sent to {recipient}");
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

 class BeforeO
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