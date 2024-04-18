using System;

// Low-level module handling message operations
public class MessageOperations
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

// High-level module directly depends on MessageOperations
public class MessageHandler
{
    private readonly MessageOperations messageOperations;

    public MessageHandler()
    {
        messageOperations = new MessageOperations();
    }

    public void SendMessage(string message, string recipient)
    {
        messageOperations.SendMessage(message, recipient);
    }

    public void ReceiveMessage(string message, string sender)
    {
        messageOperations.ReceiveMessage(message, sender);
    }

    public void DisplayMessage(string message)
    {
        messageOperations.DisplayMessage(message);
    }
}

public class Program
{
    public static void Main()
    {
        MessageHandler messageHandler = new MessageHandler();

        messageHandler.SendMessage("Hello world", "Caroline");
        messageHandler.ReceiveMessage("Hello", "Alice");
        messageHandler.DisplayMessage("Welcome!");
    }
}
