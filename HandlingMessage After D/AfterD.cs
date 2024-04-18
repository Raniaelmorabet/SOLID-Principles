using System;

public abstract class MessageHandlerBase
{
    public abstract void SendMessage(string message, string recipient);
    public abstract void ReceiveMessage(string message, string sender);
    public abstract void DisplayMessage(string message);
}

public class MessageHandler : MessageHandlerBase
{
    public override void SendMessage(string message, string recipient)
    {
        Console.WriteLine($"sending message to {recipient} : {message}");
    }

    public override void ReceiveMessage(string message, string sender)
    {
        Console.WriteLine($"receiving {message} from {sender}");
    }

    public override void DisplayMessage(string message)
    {
        Console.WriteLine($"{message}");
    }
}

public class AfterDI
{
    private readonly MessageHandlerBase messageHandler;

    public AfterDI(MessageHandlerBase handler)
    {
        messageHandler = handler;
    }

    public void SendMessage(string message, string recipient)
    {
        messageHandler.SendMessage(message, recipient);
    }

    public void ReceiveMessage(string message, string sender)
    {
        messageHandler.ReceiveMessage(message, sender);
    }

    public void DisplayMessage(string message)
    {
        messageHandler.DisplayMessage(message);
    }
}

public class Program
{
    public static void Main()
    {
        MessageHandlerBase handler = new MessageHandler();
        AfterDI afterDI = new AfterDI(handler);

        string messageToSend = "Hello world";
        string recipient = "Caroline";
        afterDI.SendMessage(messageToSend, recipient);

        string messageToReceive = "hello People";
        string sender = "Alice";
        afterDI.ReceiveMessage(messageToReceive, sender);

        string messageToDisplay = "New Message";
        afterDI.DisplayMessage(messageToDisplay);
    }
}