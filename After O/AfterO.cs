interface IMessageSender
{
    void SendMessage(string message, string recipient);
}

interface IMessageReceiver
{
    void ReceiveMessage(string message, string sender);
}

interface IMessageDisplayer
{
    void DisplayMessage(string message);
}

class MessageSenderClient : IMessageSender
{
    public void SendMessage(string message, string recipient)
    {
        Console.WriteLine($"Sending message to clent {recipient}: {message}");
    }
}

class MessageReceiver : IMessageReceiver
{
    public void ReceiveMessage(string message, string sender)
    {
        Console.WriteLine($"Receiving {message} from {sender}");
    }
}

class DisplayingMessages : IMessageDisplayer
{
    public void DisplayMessage(string message)
    {
        Console.WriteLine($"{message}");
    }
}

class Logger
{
    public static void Log(string message)
    {
        Console.WriteLine($"Logging: {message}");
    }
}

class AfterO
{
    static void Main()
    {
        IMessageSender senderClient = new MessageSenderClient();
        senderClient.SendMessage("Hello there!", "Alice");
        

        IMessageReceiver receiver = new MessageReceiver();
        receiver.ReceiveMessage("Hi!", "Bob");

        IMessageDisplayer displayer = new DisplayingMessages();
        displayer.DisplayMessage("This is a displayed message.");

        // Using the logger without modifying existing classes
        Logger.Log("Message logged.");
    }
}