class MessageHandler
{
    public void SendMessage(string message, string recipient)
    {
        Console.WriteLine($"sending message to {recipient} : {message}");
    }
    public void ReceiveMessage(string message, string sender)
    {
        Console.WriteLine($"receiving {message} from {sender}");
    }
    public void DisplayMessage(string message)
    {
        Console.WriteLine($"{message}");
    }
}


 class BeforeS
{
    static void Main()
    {
        MessageHandler messageHandler = new MessageHandler();
        string messageToSend = "Hello world";
        string recipient = "Caroline";
        messageHandler.SendMessage(messageToSend, recipient);

        string messageToReceive = "hello People";
        string sender = "Alice";
        messageHandler.ReceiveMessage(messageToReceive, sender);

        string messageToDisplay = "New Message";
        messageHandler.DisplayMessage(messageToDisplay);
    }
}